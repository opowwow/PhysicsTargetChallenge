
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Keyboard.current == null)
            return;

        float move = 0f;

        if (Keyboard.current.aKey.isPressed)
            move = -1f;

        if (Keyboard.current.dKey.isPressed)
            move = 1f;

        transform.position +=
            Vector3.right * move * moveSpeed * Time.deltaTime;
    }
}
