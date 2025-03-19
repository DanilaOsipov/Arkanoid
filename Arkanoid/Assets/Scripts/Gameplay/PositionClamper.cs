using UnityEngine;

namespace Gameplay
{
    public class PositionClamper : MonoBehaviour
    {
        [SerializeField] private Transform _minPosition;
        [SerializeField] private Transform _maxPosition;

        private void Update()
        {
            transform.position = new Vector3
            {
                x = Mathf.Clamp(transform.position.x, _minPosition.position.x, _maxPosition.position.x),
                y = Mathf.Clamp(transform.position.y, _minPosition.position.y, _maxPosition.position.y),
                z = Mathf.Clamp(transform.position.z, _minPosition.position.z, _maxPosition.position.z)
            };
        }
    }
}