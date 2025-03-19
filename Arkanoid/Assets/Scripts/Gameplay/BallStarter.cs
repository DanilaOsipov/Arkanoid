using Helpers;
using Services;
using UnityEngine;

namespace Gameplay
{
    public class BallStarter : MonoBehaviour
    {
        [SerializeField] private InputService _inputService;
        [SerializeField] private Ball _ball;

        private void OnEnable() => _inputService.OnHorizontalAxisChanged += OnAxisChangedHandler;

        private void OnDisable() => _inputService.OnHorizontalAxisChanged -= OnAxisChangedHandler;

        private void OnAxisChangedHandler(float x)
        {
            _ball.Direction = BallHelper.GetStartDirection();
            gameObject.SetActive(false);
        }
    }
}