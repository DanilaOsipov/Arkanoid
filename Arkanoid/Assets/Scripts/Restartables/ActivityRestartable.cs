using UnityEngine;

namespace Restartables
{
    public class ActivityRestartable : MonoBehaviour, IRestartable
    {
        private bool _startActivity;

        private void Awake() => _startActivity = gameObject.activeSelf;

        void IRestartable.Restart() => gameObject.SetActive(_startActivity);
    }
}