using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreValue : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TotalPoints points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Update the TextMeshPro text with the taskPercentage value
        score.text = points.Points + " points";
    }
}
