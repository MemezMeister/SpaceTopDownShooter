using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IMovement movement;

    void Start()
    {
        movement = GetComponent<IMovement>();
    }

    void Update()
    {
        RotateTowardsMouse();

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement.SetDirection(moveHorizontal, moveVertical);
    }

    void RotateTowardsMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;
    }
}
