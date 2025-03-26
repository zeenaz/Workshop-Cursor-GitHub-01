using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public float maxSpeed = 8f;
    public float airControl = 0.5f; // Less control in air (0-1)
    public int maxHealth = 3;
    
    [Header("UI")]
    public TextMeshProUGUI healthText; // Reference to UI text for health display
    
    private Rigidbody2D rb;
    private bool isGrounded;
    private float currentMoveInput;
    private int currentHealth;
    private bool isDead;
    private GameStateManager gameStateManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Set the Rigidbody2D to not rotate
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        currentHealth = maxHealth;
        isDead = false;
        gameStateManager = FindObjectOfType<GameStateManager>();
        
        if (gameStateManager == null)
        {
            Debug.LogError("PlayerController: GameStateManager not found in scene!");
        }
        
        Debug.Log($"PlayerController: Started with {currentHealth} health");
        UpdateHealthUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) return;

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
        Debug.Log($"PlayerController: Collision with {collision.gameObject.name} (Tag: {collision.gameObject.tag})");
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Enemy") && !isDead)
        {
            Debug.Log($"PlayerController: Collision with Enemy detected! Enemy name: {collision.gameObject.name}");
            EnemyController enemy = collision.gameObject.GetComponent<EnemyController>();
            if (enemy != null)
            {
                Debug.Log($"PlayerController: Found EnemyController on {collision.gameObject.name}");
                TakeDamage(enemy.damage);
            }
            else
            {
                Debug.LogError($"PlayerController: EnemyController not found on {collision.gameObject.name}");
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;
        
        currentHealth -= damage;
        Debug.Log($"PlayerController: Took {damage} damage. Current health: {currentHealth}/{maxHealth}");
        UpdateHealthUI();
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = $"Health: {currentHealth}/{maxHealth}";
        }
    }

    private void Die()
    {
        Debug.Log("PlayerController: Player died!");
        isDead = true;
        rb.velocity = Vector2.zero;
        // Notify GameStateManager
        if (gameStateManager != null)
        {
            Debug.Log("PlayerController: Notifying GameStateManager of death");
            gameStateManager.OnPlayerDeath();
        }
        else
        {
            Debug.LogError("PlayerController: GameStateManager is null when trying to notify death!");
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

    public bool IsDead()
    {
        return isDead;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}
