using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float detectionRange = 5f;
    public int damage = 1;
    
    private Transform player;
    private bool isAlive = true;
    private Rigidbody2D rb;
    private Vector2 startPosition;
    private bool isMovingRight = true;
    private bool hasRequiredComponents = false;

    private void Start()
    {
        Debug.Log($"EnemyController: Starting setup for {gameObject.name}");
        
        // Get or add required components
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError($"EnemyController: Rigidbody2D component missing on {gameObject.name}. Adding it now.");
            rb = gameObject.AddComponent<Rigidbody2D>();
        }

        // Set up Rigidbody2D
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
            rb.interpolation = RigidbodyInterpolation2D.Interpolate;
            hasRequiredComponents = true;
            Debug.Log($"EnemyController: Rigidbody2D setup complete for {gameObject.name}");
        }
        else
        {
            Debug.LogError($"EnemyController: Failed to add Rigidbody2D to {gameObject.name}. Enemy will not function correctly.");
            return;
        }

        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        if (player == null)
        {
            Debug.LogWarning($"EnemyController: No GameObject with tag 'Player' found in scene. Enemy will not track player.");
        }
        else
        {
            Debug.Log($"EnemyController: Found player at {player.position}");
        }

        startPosition = transform.position;
        Debug.Log($"EnemyController: Setup complete for {gameObject.name}");
    }

    private void Update()
    {
        if (!isAlive || !hasRequiredComponents) return;

        if (player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);
            
            if (distanceToPlayer <= detectionRange)
            {
                // Chase player
                Vector2 direction = (player.position - transform.position).normalized;
                rb.velocity = direction * moveSpeed;
            }
            else
            {
                // Patrol behavior
                Patrol();
            }
        }
    }

    private void Patrol()
    {
        // Simple patrol behavior
        if (isMovingRight)
        {
            rb.velocity = Vector2.right * moveSpeed;
            if (transform.position.x >= startPosition.x + 2f)
            {
                isMovingRight = false;
            }
        }
        else
        {
            rb.velocity = Vector2.left * moveSpeed;
            if (transform.position.x <= startPosition.x - 2f)
            {
                isMovingRight = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"EnemyController: Collision with {collision.gameObject.name} (Tag: {collision.gameObject.tag})");
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log($"EnemyController: Collision with Player detected! Attempting to deal {damage} damage");
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                player.TakeDamage(damage);
                Debug.Log("EnemyController: Successfully dealt damage to player");
            }
            else
            {
                Debug.LogError("EnemyController: PlayerController component not found on player object!");
            }
        }
    }

    public void Die()
    {
        Debug.Log($"EnemyController: Enemy {gameObject.name} died");
        isAlive = false;
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
        }
        // You can add death animation or effects here
        gameObject.SetActive(false);
    }

    public bool IsAlive()
    {
        return isAlive;
    }
} 