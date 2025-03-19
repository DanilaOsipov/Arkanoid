using Gameplay;
using UnityEngine;

namespace Restartables
{
    [RequireComponent(typeof(Ball))]
    public class BallDirectionRestartable : MonoBehaviour, IRestartable
    {
        private Ball _ball;

        private void Awake() => _ball = GetComponent<Ball>();

        void IRestartable.Restart() => _ball.Direction = Vector3.zero;
    }
}