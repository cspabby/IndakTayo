using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StepShowPolkabalHTP : MonoBehaviour
{
    public GameObject CountDown;

    public GameObject targetObject4;
    public bool isStart = false;

    public GameObject targetObject1Polkabal;
    public GameObject targetObject2Polkabal;
    public GameObject targetObject3Polkabal;
    public Button[] ButtonsChoose;
    public GameObject StepsCanvas;

    void Start()
    {

        // Ensure targetObject4 is active at the start
        if (targetObject4 != null) targetObject4.SetActive(false);

        // Ensure CountDown is hidden at the start
        if (CountDown != null) CountDown.SetActive(false);

        if (targetObject1Polkabal != null) targetObject1Polkabal.SetActive(false);
        if (targetObject2Polkabal != null) targetObject2Polkabal.SetActive(false);
        if (targetObject3Polkabal != null) targetObject3Polkabal.SetActive(false);
    }


    IEnumerator ShowObjectsWithCountDownPolkabal()
    {
        isStart = true;
        // Show the countdown
        if (CountDown != null) CountDown.SetActive(true);

        // Wait for 6 seconds
        yield return new WaitForSeconds(6f);

        // Hide the countdown
        if (CountDown != null) CountDown.SetActive(false);

        // Activate targetObject1, targetObject2, and targetObject3
        if (targetObject1Polkabal != null) targetObject1Polkabal.SetActive(true);
        if (targetObject2Polkabal != null) targetObject2Polkabal.SetActive(true);
        if (targetObject3Polkabal != null) targetObject3Polkabal.SetActive(true);

        // Deactivate targetObject4
        if (targetObject4 != null) targetObject4.SetActive(false);
    }


    public void PolkabalDanceSteps()
    {
        if (ButtonsChoose != null && ButtonsChoose.Length > 0)
        {
            foreach (Button button in ButtonsChoose)
            {
                if (button != null)
                {
                    button.interactable = false; // Disable the button
                }
            }
        }
        else
        {
            Debug.LogWarning("FinishStepsCanvas array is either null or empty.");
        }
        StepsCanvas.SetActive(true);

        StartCoroutine(ShowObjectsWithCountDownPolkabal());
    }


    public void StopDancePolkabal(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(StopDanceAfterDelay());
        }
    }

    private IEnumerator StopDanceAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait for 2 seconds


        isStart = false;

        // Reset the state of objects
        if (CountDown != null) CountDown.SetActive(false);
        if (targetObject1Polkabal != null) targetObject1Polkabal.SetActive(false);
        if (targetObject2Polkabal != null) targetObject2Polkabal.SetActive(false);
        if (targetObject3Polkabal != null) targetObject3Polkabal.SetActive(false);
        if (targetObject4 != null) targetObject4.SetActive(false);
    }
}
