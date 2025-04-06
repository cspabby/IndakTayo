using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class proceedDanceHTP : MonoBehaviour
{
    public GameObject[] objectsToMonitor; // List of UI text objects to monitor
    public BoxCollider TurnOnCollider; // Collider to enable when all texts turn green
    public GameObject TurnOnDanceCanvas;
    void Update()
    {
        if (AllTextIsGreen())
        {
            TurnOnDanceCanvas.SetActive(true);
            TurnOnCollider.enabled = true;
        }
    }

    bool AllTextIsGreen()
    {
        foreach (GameObject obj in objectsToMonitor)
        {
            TextMeshProUGUI textMesh = obj.GetComponent<TextMeshProUGUI>();
            if (textMesh == null || textMesh.color != Color.green)
            {
                TurnOnCollider.enabled = false;
                return false;
            }
        }
        return true;
    }
}
