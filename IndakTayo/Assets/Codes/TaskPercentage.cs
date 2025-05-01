using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro namespace

public class TaskPercentage : MonoBehaviour
{
    [SerializeField] private Slider progressSlider; // Assign in Inspector
    [SerializeField] private TMP_Text progressText; // Assign in Inspector

    private float taskPercentage = 0f;

    public float TaskPercentageValue => taskPercentage;

    private void Start()
    {
        taskPercentage = 0f;
        UpdateUI();
    }

    public void IncrementTaskPercentage(float incrementValue)
    {
        taskPercentage += incrementValue;
        taskPercentage = Mathf.Clamp(taskPercentage, 0f, 100f); // Clamp to 0–100%
        UpdateUI();
    }

    public void ResetTaskPercentage()
    {
        taskPercentage = 0f;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (progressSlider != null)
        {
            progressSlider.value = taskPercentage;
        }

        if (progressText != null)
        {
            progressText.text = $"{taskPercentage:F0}%";
        }
    }
}
