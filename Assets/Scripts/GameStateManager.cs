using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance { get; private set; }
    
    public enum GameState
    {
        MainMenu,
        Playing,
        Paused,
        GameOver
    }
    
    private GameState currentState;
    private PlayerController player;
    private UIManager uiManager;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentState = GameState.MainMenu;
        player = FindObjectOfType<PlayerController>();
        uiManager = FindObjectOfType<UIManager>();
    }

    public void StartGame()
    {
        currentState = GameState.Playing;
        Time.timeScale = 1f;
        if (uiManager != null)
        {
            uiManager.ShowGameUI();
        }
    }

    public void PauseGame()
    {
        if (currentState == GameState.Playing)
        {
            currentState = GameState.Paused;
            Time.timeScale = 0f;
            if (uiManager != null)
            {
                uiManager.ShowPauseMenu();
            }
        }
    }

    public void ResumeGame()
    {
        if (currentState == GameState.Paused)
        {
            currentState = GameState.Playing;
            Time.timeScale = 1f;
            if (uiManager != null)
            {
                uiManager.HidePauseMenu();
            }
        }
    }

    public void OnPlayerDeath()
    {
        currentState = GameState.GameOver;
        if (uiManager != null)
        {
            uiManager.ShowGameOverScreen();
        }
    }

    public void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMainMenu()
    {
        currentState = GameState.MainMenu;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // Make sure to create a MainMenu scene
    }

    public GameState GetCurrentState()
    {
        return currentState;
    }
} 