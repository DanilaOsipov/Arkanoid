using Services;
using UnityEngine;

namespace Gameplay
{
    public class Movable : MonoBehaviour
    {
        [SerializeField] private float _speed = 5.0f;
        [SerializeField] private TimeService _timeService;

        public void Move(Vector2 direction) => transform.position += _speed * _timeService.DeltaTime * (Vector3)direction;
    }
}