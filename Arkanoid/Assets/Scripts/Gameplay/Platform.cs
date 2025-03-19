using Services;
using UnityEngine;

namespace Gameplay
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private InputService _inputService;
        [SerializeField] private Movable _movable;

        private void OnEnable() => _inputService.OnHorizontalAxisChanged += OnAxisChangedHandler;

        private void OnDisable() => _inputService.OnHorizontalAxisChanged -= OnAxisChangedHandler;

        private void OnAxisChangedHandler(float x) => _movable.Move(new(x, 0));
    }
}