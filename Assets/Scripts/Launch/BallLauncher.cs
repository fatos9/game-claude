using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FirlatBahcesi.Launch
{
    /// <summary>
    /// Drag-back-and-release launcher for the ball.
    /// Implements: design/game-brief.md MVP feature 1 (story-001-surukle-birak-firlatma).
    /// Input: Input System Pointer (touch on device, mouse in editor). Only press+drag is
    /// used; nothing reacts to hover.
    /// Ball physics tuning and bouncing belong to story 002, which calls <see cref="NotifyBallStopped"/>.
    /// </summary>
    public class BallLauncher : MonoBehaviour
    {
        /// <summary>Launcher state. Transitions: Idle -> Aiming -> (Idle | InFlight); InFlight -> Idle via NotifyBallStopped.</summary>
        public enum LauncherState { Idle, Aiming, InFlight }

        [SerializeField] private Rigidbody2D _ball;
        [SerializeField] private LaunchSettings _settings;
        [SerializeField] private TrajectoryPreview _preview;
        [Tooltip("Defaults to Camera.main if empty.")]
        [SerializeField] private Camera _camera;
        [Tooltip("Optional. Used to size the preview cast. If empty, ballRadiusFallback is used.")]
        [SerializeField] private CircleCollider2D _ballCollider;
        [SerializeField] private float _ballRadiusFallback = 0.25f;
        [Tooltip("Keep the ball Kinematic while waiting so gravity does not move it before launch.")]
        [SerializeField] private bool _holdBallKinematicWhileIdle = true;

        // The pointer that started the current aim, and its last pressed-frame world position.
        // Release uses the cached position because the pointer's position after release is unreliable.
        private Pointer _activePointer;
        private Vector2 _lastAimWorld;

        /// <summary>Raised right after launch with the applied impulse. Launch speed is impulse divided by the ball's mass.</summary>
        public event Action<Vector2> OnBallLaunched;

        /// <summary>Raised when a pull below the minimum distance is released (no shot spent).</summary>
        public event Action OnAimCancelled;

        /// <summary>Current launcher state.</summary>
        public LauncherState State { get; private set; } = LauncherState.Idle;

        private void Start()
        {
            if (_camera == null) _camera = Camera.main;
            if (_ball == null || _settings == null || _camera == null)
            {
                Debug.LogError("BallLauncher needs a Ball, LaunchSettings and a Camera (set one tagged MainCamera). Disabling.", this);
                enabled = false;
                return;
            }
            EnterIdle();
        }

        /// <summary>
        /// Story 002 calls this when the ball has come to rest, re-enabling aiming.
        /// Ignored unless the ball is in flight.
        /// </summary>
        public void NotifyBallStopped()
        {
            if (State == LauncherState.InFlight) EnterIdle();
        }

        private void Update()
        {
            // Input is ignored entirely while in flight.
            if (State == LauncherState.InFlight) return;

            switch (State)
            {
                case LauncherState.Idle:
                {
                    Pointer pointer = Pointer.current;
                    if (pointer == null || !pointer.press.wasPressedThisFrame) break;

                    Vector2 worldPos = ScreenToWorld(pointer.position.ReadValue());
                    if (Vector2.Distance(worldPos, _ball.position) <= _settings.GrabRadius)
                    {
                        _activePointer = pointer; // stick to this device for the whole aim
                        _lastAimWorld = worldPos;
                        State = LauncherState.Aiming;
                        UpdatePreview(worldPos);
                    }
                    break;
                }

                case LauncherState.Aiming:
                    // Device removed mid-aim: cancel without a shot instead of getting stuck.
                    if (_activePointer == null || !_activePointer.added)
                    {
                        CancelAim();
                        break;
                    }

                    if (_activePointer.press.isPressed)
                    {
                        _lastAimWorld = ScreenToWorld(_activePointer.position.ReadValue());
                        UpdatePreview(_lastAimWorld);
                    }
                    else
                    {
                        ReleaseAim(_lastAimWorld);
                    }
                    break;
            }
        }

        /// <summary>
        /// Single source of truth for aim: pull is pointer minus ball, clamped to the max
        /// distance; launch direction is the opposite. Preview and launch both use this.
        /// </summary>
        private void ComputeAim(Vector2 pointerWorld, out Vector2 launchDir, out float pullDistance)
        {
            Vector2 pull = pointerWorld - _ball.position;
            pullDistance = Mathf.Min(pull.magnitude, _settings.MaxPullDistance);
            launchDir = pull.sqrMagnitude > 0f ? -pull.normalized : Vector2.zero;
        }

        private void UpdatePreview(Vector2 pointerWorld)
        {
            ComputeAim(pointerWorld, out Vector2 dir, out float dist);
            if (_preview == null) return;

            if (dist < _settings.MinPullDistance)
            {
                _preview.Hide(); // below threshold: would be cancelled, so show nothing
                return;
            }
            _preview.Show(_ball.position, dir, GetBallRadius(), _settings.PreviewMaxLength, _settings.PreviewHitMask, _ballCollider);
        }

        private void ReleaseAim(Vector2 pointerWorld)
        {
            if (_preview != null) _preview.Hide();
            ComputeAim(pointerWorld, out Vector2 dir, out float dist);

            if (dist < _settings.MinPullDistance)
            {
                CancelAim();
                return;
            }

            Vector2 impulse = dir * (dist * _settings.ImpulsePerUnit);
            State = LauncherState.InFlight;
            _ball.bodyType = RigidbodyType2D.Dynamic;
            _ball.AddForce(impulse, ForceMode2D.Impulse);
            OnBallLaunched?.Invoke(impulse);
        }

        private void CancelAim()
        {
            _activePointer = null;
            EnterIdle();
            OnAimCancelled?.Invoke();
        }

        private void EnterIdle()
        {
            State = LauncherState.Idle;
            _activePointer = null;
            if (_preview != null) _preview.Hide();
            if (_holdBallKinematicWhileIdle)
            {
                // A kinematic body keeps its residual velocity, so stop it before holding it.
                _ball.linearVelocity = Vector2.zero; // Unity 6 name (UNVERIFIED — was `velocity`)
                _ball.angularVelocity = 0f;
                _ball.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        private Vector2 ScreenToWorld(Vector2 screen)
        {
            // Orthographic 2D camera: z only needs to be in front of the camera.
            float z = -_camera.transform.position.z;
            return _camera.ScreenToWorldPoint(new Vector3(screen.x, screen.y, z));
        }

        private float GetBallRadius()
        {
            if (_ballCollider == null) return _ballRadiusFallback;
            Vector3 s = _ballCollider.transform.lossyScale;
            return _ballCollider.radius * Mathf.Max(Mathf.Abs(s.x), Mathf.Abs(s.y));
        }
    }
}
