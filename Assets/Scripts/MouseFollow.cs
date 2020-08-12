using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public float speed = 0.1F;
    Rigidbody2D movingObject;
    Vector2 playerPosition = new Vector2(0F, 0F);
    Vector3 mousePosition;

    private void Start()
    {
        movingObject = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        playerPosition = Vector2.Lerp(transform.position, mousePosition, speed);
    }


    private void FixedUpdate()
    {
        movingObject.MovePosition(playerPosition);
    }


}
