using Helpers;
using Services;
using UnityEngine;

namespace Gameplay
{
    public class BallStarter : MonoBehaviour
    {
        [SerializeField] private InputService _inputService;
        [SerializeField] private Ball _ball;

        private void OnEnable() => _inputService.OnAxisChanged += OnAxisChangedHandler;

        private void OnDisable() => _inputService.OnAxisChanged -= OnAxisChangedHandler;

        private void OnAxisChangedHandler(Vector2 axis)
        {
            _ball.Direction = BallHelper.GetStartDirection();
            _inputService.OnAxisChanged -= OnAxisChangedHandler;
        }
    }
}