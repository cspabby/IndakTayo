using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    public GameObject targetObject; 
    public StepChecker stepChecker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log("Rights");
            stepChecker.SetIndexTrue(2);
        }
    }
}
