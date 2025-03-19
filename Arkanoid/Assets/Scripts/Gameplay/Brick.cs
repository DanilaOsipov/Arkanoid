using System;
using UnityEngine;

namespace Gameplay
{
    public class Brick : MonoBehaviour
    {
        public event Action<Brick> OnBallCollisionEnter = delegate { };

        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.gameObject.TryGetComponent<Ball>(out var ball))
                return;

            OnBallCollisionEnter(this);
        }
    }
}