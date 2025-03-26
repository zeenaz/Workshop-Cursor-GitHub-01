# Naming Conventions

## General Rules
- Use clear, descriptive names
- Avoid abbreviations unless widely known
- Be consistent across all assets
- Use English for all names
- Avoid special characters except underscores

## Scripts (C#)
- Use PascalCase for class names (e.g., `PlayerController`, `GameManager`)
- Use camelCase for method names (e.g., `getHealth`, `updateScore`)
- Use camelCase for variable names (e.g., `playerSpeed`, `maxHealth`)
- Prefix private variables with underscore (e.g., `_isGrounded`, `_currentHealth`)
- Use PascalCase for public properties (e.g., `Health`, `Score`)
- Suffix interfaces with 'I' (e.g., `IDamageable`, `IInteractable`)

## Unity Assets
### Scenes
- PascalCase
- Suffix with scene type (e.g., `MainMenu_Scene`, `Level01_Scene`)
- Use underscores to separate words

### Prefabs
- PascalCase
- Suffix with type (e.g., `Player_Prefab`, `Enemy_Prefab`)
- Use underscores to separate words

### Materials
- PascalCase
- Suffix with material type (e.g., `Player_Material`, `Ground_Material`)
- Use underscores to separate words

### Textures/Sprites
- camelCase
- Suffix with type (e.g., `playerSprite`, `backgroundTexture`)
- Use descriptive names (e.g., `playerIdle`, `playerJump`)

### Animations
- camelCase
- Suffix with type (e.g., `playerIdle_Anim`, `playerJump_Anim`)
- Use descriptive names

### Audio
- camelCase
- Suffix with type (e.g., `jumpSound`, `backgroundMusic`)
- Use descriptive names

## Folders
- PascalCase
- Use underscores to separate words
- Group related assets (e.g., `Player_Assets`, `UI_Assets`)

## Tags and Layers
- PascalCase
- Use underscores to separate words
- Be descriptive (e.g., `Player_Tag`, `Ground_Layer`)

## Examples

### Scripts
```csharp
public class PlayerController : MonoBehaviour
{
    private float _moveSpeed = 5f;
    private bool _isGrounded;
    public int Health { get; set; }
    
    private void UpdateMovement()
    {
        // Implementation
    }
    
    public void TakeDamage(int damage)
    {
        // Implementation
    }
}
```

### Asset Structure
```
Assets/
├── Scripts/
│   ├── Player/
│   │   ├── PlayerController.cs
│   │   └── PlayerStats.cs
│   └── Managers/
│       └── GameManager.cs
├── Prefabs/
│   ├── Player_Prefab.prefab
│   └── Enemy_Prefab.prefab
├── Materials/
│   ├── Player_Material.mat
│   └── Ground_Material.mat
└── Sprites/
    ├── playerIdle.png
    └── playerJump.png
```

## Version Control
- Use meaningful commit messages
- Follow conventional commits format
- Include ticket/issue numbers when applicable 