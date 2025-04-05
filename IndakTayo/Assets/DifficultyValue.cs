using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DifficultyValue : MonoBehaviour
{
    public TextMeshProUGUI DifficultyText;
    public SelectDifficulty difficulty; // Ensure this is assigned in the Inspector

    void Update()
    {
        // Access the static method to get the current difficulty
        DifficultyText.text = SelectDifficulty.GetDifficulty();
    }
}
