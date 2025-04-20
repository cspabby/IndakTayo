using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttemptsValue : MonoBehaviour
{
    public TextMeshProUGUI attempts;
    public GameObject first, second, third;

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

        if(attemptsToPass == 3)
        {
            first.SetActive(true);
            second.SetActive(true);
            third.SetActive(true);
        } else if (attemptsToPass == 2)
        {
            first.SetActive(true);
            second.SetActive(true);
            third.SetActive(false);
        } else if (attemptsToPass == 1)
        {
            first.SetActive(true);
            second.SetActive(false);
            third.SetActive(false);
        }
        else if (attemptsToPass == 0)
        {
            first.SetActive(false);
            second.SetActive(false);
            third.SetActive(false);
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

    // To reset the attempts to Zero
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
