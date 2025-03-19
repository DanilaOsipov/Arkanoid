using Restartables;
using UnityEngine;

namespace Services
{
    public class TimeService : MonoBehaviour, IRestartable
    {
        public float TimeScale { get; set; }

        public float DeltaTime => Time.deltaTime * TimeScale;

        private void Awake() => TimeScale = Time.timeScale;

        void IRestartable.Restart() => TimeScale = Time.timeScale;
    }
}