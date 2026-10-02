using UnityEngine;

namespace FirlatBahcesi.Launch
{
    /// <summary>
    /// Tunable values for drag-and-release launching.
    /// Implements: design/game-brief.md, MVP feature 1 (story-001-surukle-birak-firlatma).
    /// Create via Assets > Create > Firlat Bahcesi > Launch Settings.
    /// </summary>
    [CreateAssetMenu(fileName = "LaunchSettings", menuName = "Firlat Bahcesi/Launch Settings")]
    public class LaunchSettings : ScriptableObject
    {
        [Header("Pull")]
        [Tooltip("Max pull distance in world units. Pulling further does not add power or lengthen the preview.")]
        [Min(0.01f)] public float MaxPullDistance = 2.5f;

        [Tooltip("Pulls shorter than this (world units) are cancelled and do not count as a shot.")]
        [Min(0f)] public float MinPullDistance = 0.3f;

        [Tooltip("A press must start within this radius (world units) of the ball to begin aiming.")]
        [Min(0.01f)] public float GrabRadius = 0.8f;

        [Header("Power")]
        [Tooltip("Impulse applied per world unit of (clamped) pull distance. Launch impulse = pull distance * this. Resulting speed = impulse / ball mass, so changing the ball's mass changes launch power.")]
        [Min(0f)] public float ImpulsePerUnit = 6f;

        [Header("Preview")]
        [Tooltip("Preview length in world units if nothing is hit.")]
        [Min(0.1f)] public float PreviewMaxLength = 12f;

        [Tooltip("Layers the preview can stop at. The ball's own collider is skipped in code; triggers are ignored.")]
        public LayerMask PreviewHitMask = ~0;

        private void OnValidate()
        {
            // A min pull at or above the max pull would make launching impossible.
            if (MinPullDistance >= MaxPullDistance) MinPullDistance = MaxPullDistance * 0.5f;
        }
    }
}
