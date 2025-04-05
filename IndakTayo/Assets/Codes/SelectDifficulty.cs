using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public GameObject SelectDifficultyCanvas;
    public GameObject CharacterSelectionCanvas;
    public SpeedController speedController;
    public GameObject MusicEasy;
    public GameObject MusicAverage;
    public GameObject MusicHard;
    public static float savedSpeed;
    public static string difficultyText;
    // power ups
    public GameObject[] PowerUps;
    public AudioSource musicNormal;

    // Getter for savedSpeed

     void Start()
    {
         foreach (GameObject powerUp in PowerUps)
         {
        if (powerUp != null)
                 {
            powerUp.SetActive(false);
                 }
         }
    }
    public static float GetSavedSpeed()
    {
        return savedSpeed;
    }

    public static string GetDifficulty()
    {
        return difficultyText;
    }

    public void Easy()
    {
        difficultyText = "Easy";
        speedController.speed = 0.5f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicEasy.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Average()
    {
        difficultyText = "Average";
        speedController.speed = 1.0f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicAverage.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Hard()
    {
        difficultyText = "Hard";
        speedController.speed = 1.5f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        // change to music average
        MusicAverage.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);

             foreach (GameObject powerUp in PowerUps)
        {
            if (powerUp != null)
            {
                powerUp.SetActive(true);
            }
        }




        if (musicNormal != null)
        {
            // Set the pitch to 1.5
            musicNormal.pitch = 1.5f;
            musicNormal.volume = 0.6f; // Adjust volume for higher pitch

            // Play the audio
            musicNormal.Play();
        }
        else
        {
            Debug.LogWarning("No AudioSource found on this GameObject.");
        }

    }
}
