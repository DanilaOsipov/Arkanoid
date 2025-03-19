using UnityEngine;

namespace Gameplay
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private Movable _movable;

        public Vector2 Direction { get; set; }

        private void Update() => _movable.Move(Direction);
    }
}