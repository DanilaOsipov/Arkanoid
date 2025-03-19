using UnityEngine;

namespace Services
{
    public class InputService : MonoBehaviour
    {
        public Vector2 GetAxis() => new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}