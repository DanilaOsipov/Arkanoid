using UnityEngine;

namespace Restartables
{
    public class PositionRestartable : MonoBehaviour, IRestartable
    {
        private Vector3 _startPosition;

        private void Awake() => _startPosition = transform.position;

        void IRestartable.Restart() => transform.position = _startPosition;
    }
}