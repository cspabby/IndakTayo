using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ProgressValue : MonoBehaviour
{
    public TextMeshProUGUI progress; // Text element to display progress value
    public TaskPercentage task; // Reference to the TaskPercentage script

    // Start is called before the first frame update
    void Start()
    {
        // Initialization if needed

    }

    void Update()
    {
        // Update the TextMeshPro text with the task percentage value as an integer
        progress.text = Mathf.FloorToInt(task.TaskPercentageValue) + "/100";
    }
}
