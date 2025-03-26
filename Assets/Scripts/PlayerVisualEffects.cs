using UnityEngine;

public class PlayerVisualEffects : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerController playerController;
    private Color normalColor = Color.white;
    private Color airColor = Color.red;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
        // Set initial color
        spriteRenderer.color = normalColor;
    }

    void Update()
    {
        // Update color based on player state
        spriteRenderer.color = playerController.IsInAir() ? airColor : normalColor;

        // Update sprite direction based on movement
        float moveInput = Input.GetAxisRaw("Horizontal");
        if (moveInput != 0)
        {
            spriteRenderer.flipX = moveInput > 0;
        }
    }
} 