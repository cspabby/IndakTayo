using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour
{
    public GameObject targetObject; // Assign your "LeftHand" GameObject here in the Inspector
    public StepChecker stepChecker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log("Left");
            stepChecker.SetIndexTrue(0);
        }

    }
}
