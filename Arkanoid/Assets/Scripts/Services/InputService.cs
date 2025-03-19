using System;
using UnityEngine;

namespace Services
{
    public class InputService : MonoBehaviour
    {
        public event Action<Vector2> OnAxisChanged = delegate { };

        private void Update() => HandleInput();

        private void HandleInput()
        {
            Vector2 axis = new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if (axis == Vector2.zero)
                return;

            OnAxisChanged(axis);
        }
    }
}