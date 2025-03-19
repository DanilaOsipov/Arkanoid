using System;
using UnityEngine;

namespace Services
{
    public class InputService : MonoBehaviour
    {
        public event Action<float> OnHorizontalAxisChanged = delegate { };
        public event Action<float> OnVerticalAxisChanged = delegate { };

        private void Update() => HandleInput();

        private void HandleInput()
        {
            Vector2 axis = new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if (axis == Vector2.zero)
                return;

            if (axis.x != 0) OnHorizontalAxisChanged(axis.x);
            if (axis.y != 0) OnVerticalAxisChanged(axis.y);
        }
    }
}