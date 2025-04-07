using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPassHTP : MonoBehaviour
{
    public StepShowHTP ShowDancePass;

    //Start the Script

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ShowDancePass.ShowDancePass(other);

        }
    }

}
