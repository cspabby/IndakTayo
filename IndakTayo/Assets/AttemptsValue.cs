using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttemptsValue : MonoBehaviour
{
    public TextMeshProUGUI attempts;

    void Update()
    {
        // getting the value of attempts
        int attemptsToPass = PlayerPrefs.GetInt("attempts");

        if (attemptsToPass > 3)
        {
            attemptsToPass = 3;
            PlayerPrefs.SetInt("attempts", attemptsToPass);
            PlayerPrefs.Save();
        }

        attempts.text = attemptsToPass.ToString();
    }
    // Setter for attempts
    public void SetNumberOfAttempts()
    {
        int attemptsToPass = PlayerPrefs.GetInt("attempts");

        if (attemptsToPass < 3)
        {
            attemptsToPass += 1;
            PlayerPrefs.SetInt("attempts", attemptsToPass);
            PlayerPrefs.Save();
        }
    }

    public void ResetAttempts()
    {
        PlayerPrefs.SetInt("attempts", 0);
        PlayerPrefs.Save();
    }

    public int GetAttemptsToPass()
    {
        return PlayerPrefs.GetInt("attempts");
    }
}
