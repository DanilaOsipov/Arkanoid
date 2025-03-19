using Services;
using UnityEngine;

namespace Gameplay
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private InputService _inputService;
        [SerializeField] private Movable _movable;

        private void Update() => _movable.Move(_inputService.GetAxis());
    }
}