using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject gameUIPanel;
    public GameObject pauseMenuPanel;
    public GameObject gameOverPanel;

    [Header("Game UI Elements")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    private PlayerController player;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        ShowMainMenu();
    }

    private void Update()
    {
        if (GameStateManager.Instance.GetCurrentState() == GameStateManager.GameState.Playing)
        {
            UpdateGameUI();
        }
    }

    private void UpdateGameUI()
    {
        if (player != null)
        {
            healthText.text = $"Health: {player.GetCurrentHealth()}";
        }
    }

    public void ShowMainMenu()
    {
        HideAllPanels();
        mainMenuPanel.SetActive(true);
    }

    public void ShowGameUI()
    {
        HideAllPanels();
        gameUIPanel.SetActive(true);
    }

    public void ShowPauseMenu()
    {
        pauseMenuPanel.SetActive(true);
    }

    public void HidePauseMenu()
    {
        pauseMenuPanel.SetActive(false);
    }

    public void ShowGameOverScreen()
    {
        HideAllPanels();
        gameOverPanel.SetActive(true);
    }

    private void HideAllPanels()
    {
        mainMenuPanel.SetActive(false);
        gameUIPanel.SetActive(false);
        pauseMenuPanel.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    // Button click handlers
    public void OnStartGameButtonClick()
    {
        GameStateManager.Instance.StartGame();
    }

    public void OnPauseButtonClick()
    {
        GameStateManager.Instance.PauseGame();
    }

    public void OnResumeButtonClick()
    {
        GameStateManager.Instance.ResumeGame();
    }

    public void OnRestartButtonClick()
    {
        GameStateManager.Instance.RestartGame();
    }

    public void OnMainMenuButtonClick()
    {
        GameStateManager.Instance.ReturnToMainMenu();
    }
} 