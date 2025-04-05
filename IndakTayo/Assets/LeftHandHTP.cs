using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyHTP : MonoBehaviour
{
    public GameObject targetObject; // Assign your "LeftHand" GameObject here in the Inspector
    public StepCheckerHTP stepChecker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            stepChecker.SetIndexTrue(0);
        }

    }
}
