using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public float maxSpeed = 8f;
    public float airControl = 0.5f; // Less control in air (0-1)
    
    private Rigidbody2D rb;
    private bool isGrounded;
    private float currentMoveInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Set the Rigidbody2D to not rotate
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from both A-D keys and arrow keys
        currentMoveInput = Input.GetAxisRaw("Horizontal");
        
        // Calculate movement speed
        float currentSpeed = currentMoveInput * moveSpeed;
        
        // If in air, reduce movement control
        if (!isGrounded)
        {
            currentSpeed *= airControl;
        }
        
        // Apply movement
        rb.velocity = new Vector2(currentSpeed, rb.velocity.y);

        // Clamp the maximum speed
        if (Mathf.Abs(rb.velocity.x) > maxSpeed)
        {
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        }

        // Jump when space is pressed and player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
    }

    // Check if player is grounded
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    // Public methods for other scripts to access player state
    public bool IsInAir()
    {
        return !isGrounded;
    }

    public float GetMoveDirection()
    {
        return currentMoveInput;
    }
}
