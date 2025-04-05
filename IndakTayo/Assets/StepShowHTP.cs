using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepShowHTP : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject targetObject1ShowSteps;
    public GameObject targetObject2CenterBody;
    public GameObject targetObject3Pass;
    public GameObject targetObject4Duck;
    public GameObject targetObject5Slide;
    public GameObject targetObject6Dodge;
    public GameObject targetObject7Congrats;
    public GameObject HideCountDown;
    public GameObject StepsCanvas;
    public bool isStart = false;



    void Start()
    {
        // Ensure all target objects are initially hidden
          targetObject1ShowSteps.SetActive(false);
          targetObject2CenterBody.SetActive(false);
          targetObject3Pass.SetActive(false);
          targetObject4Duck.SetActive(false);
          targetObject5Slide.SetActive(false);
          targetObject6Dodge.SetActive(false);
          targetObject7Congrats.SetActive(false);
        // Ensure CountDown is hidden at the start
        if (CountDown != null) CountDown.SetActive(false);

    }

  
    IEnumerator ShowObjectsWithCountDownJotabal()
    {
        isStart = true;
        // Show the countdown
        if (CountDown != null) CountDown.SetActive(true);

        // Wait for 6 seconds
        yield return new WaitForSeconds(6f);

        // Hide the countdown
        if (HideCountDown != null) HideCountDown.SetActive(false);

        if (targetObject1ShowSteps != null) targetObject1ShowSteps.SetActive(true);
        if (targetObject2CenterBody != null) targetObject2CenterBody.SetActive(true);

    }

    public void ShowDancePass(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetObject2CenterBody.SetActive(false);
            targetObject3Pass.SetActive(true);
            targetObject4Duck.SetActive(false);
            targetObject5Slide.SetActive(false);
            targetObject6Dodge.SetActive(false);
            targetObject7Congrats.SetActive(false);
        }

    }

    public void ShowDanceDuck(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetObject2CenterBody.SetActive(false);
            targetObject3Pass.SetActive(false);
            targetObject4Duck.SetActive(true);
            targetObject5Slide.SetActive(false);
            targetObject6Dodge.SetActive(false);
            targetObject7Congrats.SetActive(false);
        }

    }
    public void ShowDanceSlide(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetObject2CenterBody.SetActive(false);
            targetObject3Pass.SetActive(false);
            targetObject4Duck.SetActive(false);
            targetObject5Slide.SetActive(true);
            targetObject6Dodge.SetActive(false);
            targetObject7Congrats.SetActive(false);
        }
    }
    public void ShowDanceDodge(Collider other)
    {
        targetObject2CenterBody.SetActive(false);
        targetObject3Pass.SetActive(false);
        targetObject4Duck.SetActive(false);
        targetObject5Slide.SetActive(false);
        targetObject6Dodge.SetActive(true);
        targetObject7Congrats.SetActive(false);
    }

    public void ShowDanceCongrats(Collider other)
    {
        targetObject2CenterBody.SetActive(false);
        targetObject3Pass.SetActive(false);
        targetObject4Duck.SetActive(false);
        targetObject5Slide.SetActive(false);
        targetObject6Dodge.SetActive(false);
        targetObject7Congrats.SetActive(true);


    }


    //  public void JotabalDanceSteps()
    // {
    //     if (ButtonsChoose != null && ButtonsChoose.Length > 0)
    //     {
    //         foreach (Button button in ButtonsChoose)
    //         {
    //             if (button != null)
    //              {
    //                  button.interactable = false; // Disable the button
    //              }
    //          }
    //     }
    //      else
    //      {
    //          Debug.LogWarning("FinishStepsCanvas array is either null or empty.");
    //     }

    //  StepsCanvas.SetActive(true);

    //  StartCoroutine(ShowObjectsWithCountDownJotabal());

    //}


    public void StopDance(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(StopDanceAfterDelay());
        }
    }
        
    public void StartDance(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ShowObjectsWithCountDownJotabal());
        }
    }

    private IEnumerator StopDanceAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait for 2 seconds


        isStart = false;

        // Reset the state of objects
        if (CountDown != null) CountDown.SetActive(false);
        targetObject1ShowSteps.SetActive(false);
        targetObject2CenterBody.SetActive(false);
        targetObject3Pass.SetActive(false);
        targetObject4Duck.SetActive(false);
        targetObject5Slide.SetActive(false);
        targetObject6Dodge.SetActive(false);
        // Ensure CountDown is hidden at the start
        if (CountDown != null) CountDown.SetActive(false);
    }
}
