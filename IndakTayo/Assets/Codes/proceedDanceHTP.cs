using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class proceedDanceHTP : MonoBehaviour
{
    public GameObject[] objectsToMonitor; // List of UI text objects to monitor
    public BoxCollider TurnOnCollider; // Collider to enable when all texts turn green
    public GameObject TurnOnDanceCanvas; // Canvas to show when ready
    void Update()
    {
         // Continuously check if all monitored texts are green
        if (AllTextIsGreen())
        {
            TurnOnDanceCanvas.SetActive(true); // Show the canvas
            TurnOnCollider.enabled = true; // Enable the collider to proceed

        }
    }
    // Check if all TextMeshPro elements are colored green
    bool AllTextIsGreen()
    {
        foreach (GameObject obj in objectsToMonitor)
        {
            TextMeshProUGUI textMesh = obj.GetComponent<TextMeshProUGUI>();
            if (textMesh == null || textMesh.color != Color.green)
            {
                TurnOnCollider.enabled = false; // Prevent proceeding if any text isn't green
                return false;
            }
        }
        return true;
    }
}
