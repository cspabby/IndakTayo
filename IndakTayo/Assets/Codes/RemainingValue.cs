using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainingValue : MonoBehaviour
{
    public TextMeshProUGUI RemainingText; // Assign in Inspector
    public GameObject ButtonAttempts;
    public GameObject NextButton;
    public GameObject TextAttempts;
    public TaskPercentage percent; 
    void Update()
    {
        int attemptsToPass = PlayerPrefs.GetInt("attempts");
        int remaining = 3 - attemptsToPass;
        float percentValue = percent.TaskPercentageValue;

        if (remaining < 0)
        {
            remaining = 0;
        }

        RemainingText.text = remaining.ToString();

        if (percentValue < 100)
        {
            if (remaining == 0)
            {
                ButtonAttempts.SetActive(false);
                TextAttempts.SetActive(true);
            }
            else
            {
                ButtonAttempts.SetActive(true);
            }
        }
        else
        {
            NextButton.SetActive(true);
        }
    }

}
