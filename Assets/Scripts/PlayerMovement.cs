using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // The speed of the player
    public float speed = 5f;

    // The acceleration of the player
    public float acceleration = 0.1f;

    // The maximum speed of the player
    public float maxSpeed = 10f;

    // The Rigidbody2D component of the player
    private Rigidbody2D rb;

    // The current direction of the player's movement
    private Vector2 direction;

    // The time when the player started moving in the current direction
    private float startTime;

    void Start()
    {
        // Get the Rigidbody2D component of the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Update the current direction of the player based on the input
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
        }
        // If the player is moving in a new direction, reset the start time
        if (direction != Vector2.zero && direction != rb.velocity.normalized)
        {
            startTime = Time.time;
        }

        // Calculate the current speed of the player based on the elapsed time and the acceleration
        float currentSpeed = Mathf.Min(speed + (Time.time - startTime) * acceleration, maxSpeed);

        // Move the player in the current direction at the current speed
        rb.AddForce(direction * currentSpeed);
    }
    
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if ( Other.tag == "Door")
        Debug.Log("Level Complete!!!");
    }
}
