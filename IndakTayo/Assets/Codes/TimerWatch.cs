using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerWatch : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Assign this in the Inspector
    public bool startTimer = false;  // Set to true to start the timer
    public bool isPaused = false;    // Set to true to pause the timer

    public float elapsedTime = 0f;
    private float targetTime = 4 * 60 + 45; // Target time in seconds (4 minutes 45 seconds)

    void Update()
    {
        if (startTimer && !isPaused && elapsedTime < targetTime)
        {
            // Use the saved speed from SelectDifficulty to affect the timer progression
            elapsedTime += Time.deltaTime * SelectDifficulty.savedSpeed;

            if (elapsedTime >= targetTime)
            {
                elapsedTime = targetTime; // Stop the timer at 4:45
                startTimer = false;       // Stop the timer
            }

            UpdateTimerDisplay(elapsedTime);
        }
    }

    public void PauseTimer()
    {
        isPaused = true;
    }

    public void ResumeTimer()
    {
        isPaused = false;
    }

    public void UpdateTimerDisplay(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = $"{minutes:D2}:{seconds:D2}";
    }

    public float GetElapsedTime()
    {
        return elapsedTime;
    }
}
