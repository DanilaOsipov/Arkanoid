using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay
{
    public class BricksFacade : MonoBehaviour
    {
        [SerializeField] private Brick[] _bricks;
        [SerializeField] private UnityEvent _onAllBricksDestroyed = new UnityEvent();

        private void Awake()
        {
            foreach (var brick in _bricks)
            {
                brick.OnBallCollisionEnter += OnBallCollisionEnterHandler;
            }
        }

        private void OnDestroy()
        {
            foreach (var brick in _bricks)
            {
                brick.OnBallCollisionEnter -= OnBallCollisionEnterHandler;
            }
        }

        private void OnBallCollisionEnterHandler(Brick brick)
        {
            brick.gameObject.SetActive(false);
            bool allDestroyed = _bricks.All(e => !e.gameObject.activeSelf);
            if (allDestroyed) _onAllBricksDestroyed.Invoke();
        }
    }
}