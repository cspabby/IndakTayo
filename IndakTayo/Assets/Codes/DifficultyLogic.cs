using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLogic : MonoBehaviour
{
    public Button Average;
    public Button Hard;

    void Start()
    {
        // Retrieve saved difficulty states
        int isAverage = PlayerPrefs.GetInt("isAverage", 0); // Correct key for Average difficulty
        int isHard = PlayerPrefs.GetInt("isHard", 0);       // Correct key for Hard difficulty

        // Set buttons' interactability based on saved difficulty states
        Average.interactable = (isAverage == 0); //optional: changed to zero to be set available
        Hard.interactable = (isHard == 0); //optional: changed to zero to be set available
    }
}
