using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSlideHTP : MonoBehaviour
{
    // Start is called before the first frame update
    public StepShowHTP ShowDancePass;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //Player compare tag
        {

            ShowDancePass.ShowDanceSlide(other); //If dance pass

        }
    }
}
