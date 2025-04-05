using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandScore : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public TotalPoints totalPoints;

    // Start is called before the first frame update
    void Start()
    {
        // Assuming TotalPoints is on the same GameObject
        totalPoints = GetComponent<TotalPoints>();

        // Ensure totalPoints is assigned
        if (totalPoints == null)
        {
            totalPoints = GameObject.FindObjectOfType<TotalPoints>();
            if (totalPoints == null)
            {
                Debug.LogWarning("TotalPoints component not found in the scene.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (totalPoints != null)
        {
            // Update the TextMeshPro text with the points value
            textMeshPro.text = totalPoints.Points + " pts.";
        }
    }
}
