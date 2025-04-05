using System.Collections;
using UnityEngine;
using TMPro;

public class ScorePointsOverlay : MonoBehaviour
{
    public GameObject Time;
    public GameObject Points;
    public GameObject Percentage;

    public TotalPoints totalPointsScript;   // Reference to the TotalPoints script
    public TimerWatch timerWatchScript;    // Reference to the TimerWatch script
    public TaskPercentage taskPercentageScript; // Reference to the TaskPercentage script

    private TextMeshProUGUI timeText;      // Text component for Time
    private TextMeshProUGUI pointsText;    // Text component for Points
    private TextMeshProUGUI percentageText; // Text component for Percentage

    void Start()
    {
        // Initialize TextMeshPro references
        if (Time != null) timeText = Time.GetComponent<TextMeshProUGUI>();
        if (Points != null) pointsText = Points.GetComponent<TextMeshProUGUI>();
        if (Percentage != null) percentageText = Percentage.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Update the text fields with values from the respective scripts
        if (timeText != null && timerWatchScript != null)
        {
            float elapsedTime = timerWatchScript.GetElapsedTime();
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timeText.text = $"Time: {minutes:D2}:{seconds:D2}";
        }

        if (pointsText != null && totalPointsScript != null)
        {
            pointsText.text = $"Score: {totalPointsScript.Points} Points";
        }

        if (percentageText != null && taskPercentageScript != null)
        {
            percentageText.text = $"Percentage: {taskPercentageScript.TaskPercentageValue}%";
        }
    }
}
