
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveRange = 1f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        float movement = Mathf.Sin(Time.fixedTime * moveSpeed)
                         * moveRange;

        transform.position =
            startPosition + new Vector3(movement, 0, 0);
    }
}
