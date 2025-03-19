using UnityEngine;

namespace Helpers
{
    public static class BallHelper
    {
        private const float DIRECTION_DELTA = 45.0f;

        public static Vector2 GetStartDirection()
        {
            var deltaRad = DIRECTION_DELTA * Mathf.Deg2Rad;
            var randomAngle = Random.Range((Mathf.PI / 2) - deltaRad, (Mathf.PI / 2) + deltaRad);
            return new Vector2(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle));
        }
    }
}