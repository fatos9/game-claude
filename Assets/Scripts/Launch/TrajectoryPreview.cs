using UnityEngine;

namespace FirlatBahcesi.Launch
{
    /// <summary>
    /// Draws the aim preview as a line from the ball to the first thing it would hit.
    /// Uses a single Physics2D.CircleCast (no simulation). Presentation only; it never
    /// moves the ball. Implements: story-001 (preview up to first bounce).
    /// </summary>
    [RequireComponent(typeof(LineRenderer))]
    public class TrajectoryPreview : MonoBehaviour
    {
        private LineRenderer _line;
        private readonly RaycastHit2D[] _hits = new RaycastHit2D[8]; // allocated once; no per-frame GC
        private ContactFilter2D _filter;

        private void Awake()
        {
            _line = GetComponent<LineRenderer>();
            _line.useWorldSpace = true;
            _line.positionCount = 2;
            _line.enabled = false;
            _filter = new ContactFilter2D { useTriggers = false };
        }

        /// <summary>
        /// Shows the preview from <paramref name="origin"/> along <paramref name="direction"/>
        /// (normalized), stopping at the first collider hit by a circle of <paramref name="ballRadius"/>.
        /// </summary>
        public void Show(Vector2 origin, Vector2 direction, float ballRadius, float maxLength,
                         LayerMask hitMask, Collider2D ignore)
        {
            // The cast starts inside the ball's own collider, so skip it explicitly instead of
            // relying on layer setup. Take the nearest remaining hit (results are not assumed sorted).
            _filter.SetLayerMask(hitMask);
            int count = Physics2D.CircleCast(origin, ballRadius, direction, _filter, _hits, maxLength);

            float nearest = float.MaxValue;
            Vector2 end = origin + direction * maxLength;
            for (int i = 0; i < count; i++)
            {
                RaycastHit2D h = _hits[i];
                if (h.collider == null || h.collider == ignore) continue;
                if (h.distance < nearest)
                {
                    nearest = h.distance;
                    end = h.centroid;
                }
            }

            _line.SetPosition(0, origin);
            _line.SetPosition(1, end);
            _line.enabled = true;
        }

        /// <summary>Hides the preview.</summary>
        public void Hide()
        {
            _line.enabled = false;
        }
    }
}
