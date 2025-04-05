using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsShow : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject targetObject1;
    public GameObject targetObject2;
    public GameObject targetObject3;
    public GameObject targetObject4;
    public bool isStart = false;
    public TimerWatch timerDisplay;
    public GameObject NoLogicStopGO;
    public GameObject LogicStopGO;

    void Start()
    {
        LogicStopGO.SetActive(false);
        NoLogicStopGO.SetActive(true);
        // Ensure all target objects are initially hidden
        if (targetObject1 != null) targetObject1.SetActive(false);
        if (targetObject2 != null) targetObject2.SetActive(false);
        if (targetObject3 != null) targetObject3.SetActive(false);

        // Ensure targetObject4 is active at the start
        if (targetObject4 != null) targetObject4.SetActive(true);

        // Ensure CountDown is hidden at the start
        if (CountDown != null) CountDown.SetActive(false);
    }

    void Update()
    {
        if (isStart)
        {
            // Start the sequence to show CountDown and activate objects after delay
            StartCoroutine(ShowObjectsWithCountDown());
            isStart = false;  // Prevent the coroutine from starting multiple times
        }
    }

    IEnumerator ShowObjectsWithCountDown()
    {
        // Show the countdown
        if (CountDown != null) CountDown.SetActive(true);

        // Wait for 6 seconds
        yield return new WaitForSeconds(6f);

        // Hide the countdown
        if (CountDown != null) CountDown.SetActive(false);

        // Activate targetObject1, targetObject2, and targetObject3
        if (targetObject1 != null) targetObject1.SetActive(true);
        if (targetObject2 != null) targetObject2.SetActive(true);
        if (targetObject3 != null) targetObject3.SetActive(true);

        // Deactivate targetObject4
        if (targetObject4 != null) targetObject4.SetActive(false);

        // Start the timer if timerDisplay is assigned
        if (timerDisplay != null)
        {
            timerDisplay.startTimer = true;
            LogicStopGO.SetActive(true);
            NoLogicStopGO.SetActive(false);
        }
        else
        {
            Debug.LogWarning("TimerWatch reference (timerDisplay) is missing!");
        }
    }

    public void StartSequence()
    {
        isStart = true;
    }
}
