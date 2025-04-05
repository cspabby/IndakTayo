using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandHTP : MonoBehaviour
{
    public GameObject targetObject;
    public StepCheckerHTP stepChecker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log("Rights");
            stepChecker.SetIndexTrue(2);
        }
    }
}
