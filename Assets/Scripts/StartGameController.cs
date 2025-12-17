using UnityEngine;

public class StartGameController : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject hudCanvas;
    public GameObject player;

    private bool gameStarted = false;

    void Start()
    {
        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (hudCanvas != null)
            hudCanvas.SetActive(false);
    }

    void Update()
    {
        if (gameStarted) return;

        if (Input.anyKeyDown)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        gameStarted = true;

        Time.timeScale = 1f;

        if (startCanvas != null)
            startCanvas.SetActive(false);

        if (hudCanvas != null)
            hudCanvas.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}