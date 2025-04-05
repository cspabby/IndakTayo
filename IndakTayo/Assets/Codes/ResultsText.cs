using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultsText : MonoBehaviour
{
    public TextMeshProUGUI Results;   // Assign the TextMeshPro component in the Inspector
    public TaskPercentage task;      // Reference to the TaskPercentage script

    void Update()
    {
        // Check the task percentage and update the Results text accordingly
        if (task.TaskPercentageValue == 100)
        {
            Results.text = "YOU HAVE COMPLETED THE JOTABAL DANCE!!!";
        }
        else
        {
            Results.text = "GAME OVER";
        }
    }
}
