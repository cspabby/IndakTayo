using UnityEngine;
using TMPro;

public class TaskPercentage : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private float taskPercentage = 0;

    void Update()
    {
        // Display the taskPercentage as a whole number (integer)
        textMeshPro.text = Mathf.FloorToInt(taskPercentage) + "%";  // Floors the value to nearest lower integer
    }

    public float TaskPercentageValue
    {
        get { return taskPercentage; }
    }

    public void IncrementTaskPercentage(float incrementValue)
    {
        taskPercentage += incrementValue;
        if (taskPercentage >= 100)
        {
            taskPercentage = 100;
        }
    }
}
