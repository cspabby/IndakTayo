using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceProgress : MonoBehaviour
{
    public GameObject Player;
    public TaskPercentage percent;
    private string music;

    private bool hasCollided = false;

    private void Awake()
    {
        // Fetch the stored music value once in Awake or Start
        music = PlayerPrefs.GetString("music");
    }

    private void OnTriggerEnter(Collider other)
    {
        // Ensure that we only process this once, and if the other object is one of the designated parts (Head, Right, Left)
        if (!hasCollided && (other.gameObject == Player))
        {

            Debug.Log("MALI");
            if (music == "Jotabal")
            {
                // Use 'StartDance.GetGender()' to call the static method
                if (StartDance.GetGender() == "Male")
                {
                    percent.IncrementTaskPercentage(1.69f);
                }
                else if (StartDance.GetGender() == "Female")
                {
                    percent.IncrementTaskPercentage(1);
                }

            }

            if (music == "Polkabal")
            {
                // Use 'StartDance.GetGender()' to call the static method
                if (StartDance.GetGender() == "Male")
                {
                    percent.IncrementTaskPercentage(1.69f);
                }
                else if (StartDance.GetGender() == "Female")
                {
                    percent.IncrementTaskPercentage(1);
                }

            }

            hasCollided = true;
        }
    }
}
