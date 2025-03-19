using Restartables;
using UnityEngine;

namespace Services
{
    public class RestartService : MonoBehaviour
    {
        [SerializeField] private Transform _restartablesRoot;

        public void Restart()
        {
            var restartables = _restartablesRoot
                .GetComponentsInChildren<IRestartable>(includeInactive: true);

            foreach (var restartable in restartables)
                restartable.Restart();
        }
    }
}