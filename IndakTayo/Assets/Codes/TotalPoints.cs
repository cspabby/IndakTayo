using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalPoints : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private int points = 0;
    public int pointsMultiplier = 1; // Default multiplier is 1x

    void Update()
    {
        // Update the TextMeshPro text with points value
        textMeshPro.text = points + " pts";
    }

    // Property to get the points value
    public int Points
    {
        get { return points; }
    }

    // Function to increment points by a specified value
    public void IncrementPoints(int incrementValue)
    {
        points += incrementValue * pointsMultiplier; // Apply multiplier
    }

    // Function to decrement points by a specified value
    public void DecrementPoints(int decrementValue)
    {
        points -= decrementValue;
        if (points < 0)
        {
            points = 0; // Ensure points does not go negative
        }
    }
}
