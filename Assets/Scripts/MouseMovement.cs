using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float speed = 5f;
    public float minXLimit = -5f;
    public float maxXLimit = 5f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X"); // ← сглаженное движение
        float moveX = mouseX * speed;

        float newX = Mathf.Clamp(
            transform.position.x + moveX,
            startPosition.x + minXLimit,
            startPosition.x + maxXLimit
        );

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
