using UnityEngine;

namespace Services
{
    public class PauseService : MonoBehaviour
    {
        [SerializeField] private TimeService _timeService;

        public void Pause() => _timeService.TimeScale = 0;
    }
}