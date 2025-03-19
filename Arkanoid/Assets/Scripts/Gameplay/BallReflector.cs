using UnityEngine;

namespace Gameplay
{
    public class BallReflector : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.gameObject.TryGetComponent<Ball>(out var ball))
                return;

            ball.Direction = Vector2.Reflect(ball.Direction, collision.contacts[0].normal);
        }
    }
}