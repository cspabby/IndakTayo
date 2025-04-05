using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorTaskMonitor : MonoBehaviour
{

    public GameObject[] objectsToMonitor;
    public BoxCollider TurnOnCollider;
    public GameObject TurnOffFistCanvas;
    public GameObject IMUCanvas;
    public GameObject IMUCanvas1;
    void Update()
    {
        if (AllTextIsGreen())
        {

            TurnOnCollider.enabled = true;
            TurnOffFistCanvas.SetActive(false);
            IMUCanvas.SetActive(true);
            IMUCanvas1.SetActive(true);
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
