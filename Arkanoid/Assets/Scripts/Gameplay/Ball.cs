using Restartables;
using UnityEngine;

namespace Gameplay
{
    public class Ball : MonoBehaviour, IRestartable
    {
        [SerializeField] private Movable _movable;

        public Vector2 Direction { get; set; }

        void IRestartable.Restart() => Direction = Vector2.zero;

        private void Update() => _movable.Move(Direction);
    }
}