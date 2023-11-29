using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public TMP_Text displayTimeText;

    private float initialTime = 1600;
    public float currentTime = 1600;

    private float displayMinutes;
    private float displaySeconds;
    public UnityEvent WinnerEvent;

    public UnityEvent gameOverEvent;

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        // Calculate minutes and seconds
        displayMinutes = Mathf.Floor(currentTime / 60);
        displaySeconds = Mathf.Round(currentTime % 60);

        // Display the time in minutes:seconds format
        displayTimeText.text = $"{displayMinutes:00}:{displaySeconds:00}";

        if (currentTime < 0)
        {
            Time.timeScale = 0;
            gameOverEvent.Invoke();
            displayTimeText.text = "Game Over, Try Again";
        }
    }

    public void Winner()
    {
        float timePassed = initialTime - currentTime;

        // Calculate minutes and seconds for the time passed
        float minutesPassed = Mathf.Floor(timePassed / 60);
        float secondsPassed = Mathf.Round(timePassed % 60);

        displayTimeText.text = $"Congratulations! You escaped in: {minutesPassed:00}:{secondsPassed:00}";
        WinnerEvent.Invoke();
    }
}