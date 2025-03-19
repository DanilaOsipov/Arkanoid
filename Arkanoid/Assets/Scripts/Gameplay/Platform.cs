using Services;
using UnityEngine;

namespace Gameplay
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private InputService _inputService;
        [SerializeField] private Movable _movable;

        private void OnEnable() => _inputService.OnAxisChanged += OnAxisChangedHandler;

        private void OnDisable() => _inputService.OnAxisChanged -= OnAxisChangedHandler;

        private void OnAxisChangedHandler(Vector2 axis) => _movable.Move(axis);
    }
}