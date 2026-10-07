using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // cache variable for rigid body
    // prevent it to get every frame
    Rigidbody2D rb;

    public float movementSpeed = 2f;
    public float jumpSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-movementSpeed, rb.linearVelocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(movementSpeed, rb.linearVelocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
        }
    }
}
