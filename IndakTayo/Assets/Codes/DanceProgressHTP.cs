using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceProgressHTP : MonoBehaviour
{
    public GameObject Head;
    public GameObject Right;
    public GameObject Left;
    public TaskPercentage percent;

    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && (other.gameObject == Head || other.gameObject == Right || other.gameObject == Left))
        {
            Debug.Log("MALI");
            percent.IncrementTaskPercentage(20);
            hasCollided = true;
        }
    }
}
