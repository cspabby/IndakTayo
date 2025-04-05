using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPIMUScriptCanvas : MonoBehaviour
{

    public GameObject CongratsCanvas;
    public StepShowHTP StopDanceHTP;  
    public StepShowPolkabalHTP StopDancePolkabalHTP;

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopDanceHTP.ShowDanceCongrats(other);
            StopDanceHTP.StopDance(other);
            StopDancePolkabalHTP.StopDancePolkabal(other);
            StartCoroutine(ShowCongratsCanvasWithDelay());
        }
    }


    private IEnumerator ShowCongratsCanvasWithDelay()
    {
        yield return new WaitForSeconds(1f); // Wait for 2 seconds
        CongratsCanvas.SetActive(true); // Activate the canvas
    }
}
