using UnityEngine;
using UnityEngine.Events;

namespace Gameplay
{
    public class BallMissingZone : MonoBehaviour
    {
        [SerializeField] private UnityEvent _onBallMissing = new UnityEvent();

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponentInParent<Ball>() != null)
                _onBallMissing.Invoke();
        }
    }
}