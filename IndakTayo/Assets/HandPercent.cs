using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandPercent : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Text field to display the percentage
    public TaskPercentage taskPercentage; // Reference to TaskPercentage component

    void Start()
    {
        // Check if taskPercentage is assigned in the Inspector
        if (taskPercentage == null)
        {
            // Try to find TaskPercentage on the same GameObject if not assigned
            taskPercentage = GetComponent<TaskPercentage>();

            // If TaskPercentage is on a different GameObject, assign it manually in the Inspector
            if (taskPercentage == null)
            {
                Debug.LogWarning("TaskPercentage component not found!");
            }
        }
    }

    void Update()
    {
        if (taskPercentage != null)
        {
            // Get the current percentage from TaskPercentage
            float currentPercentage = taskPercentage.TaskPercentageValue;

            // Display only the whole number (without decimals) using Mathf.FloorToInt() or Mathf.RoundToInt()
            textMeshPro.text = Mathf.FloorToInt(currentPercentage) + "%";  // Using Floor to remove decimal places
        }
    }
}
