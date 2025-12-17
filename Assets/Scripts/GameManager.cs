using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalCollectibles = 6;
    public int collected = 0;

    public TMP_Text counterText;

    public GameObject winPanel;
    public TMP_Text winText;

    private float startTime;

    void Awake() => instance = this;

    void Start()
    {
        startTime = Time.time;
        UpdateUI();
        if (winPanel != null) winPanel.SetActive(false);
    }

    public void Collect()
    {
        collected++;
        UpdateUI();

        if (collected >= totalCollectibles)
            Win();
    }

    void UpdateUI()
    {
        if (counterText != null)
            counterText.text = $"Mysterious Gold Coins: {collected} / {totalCollectibles}";
    }

    void Win()
    {
        float t = Time.time - startTime;
        if (winPanel != null) winPanel.SetActive(true);
        if (winText != null) winText.text = $"You got all the mysterious gold coins!\nYou're awake and today will be full of energy!\nTime: {t:0.0}s";
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}