using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDuckHTP : MonoBehaviour
{
    // Start is called before the first frame update
    public StepShowHTP ShowDancePass;


    //script for duck HTP
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //player indicator
        {

            ShowDancePass.ShowDanceDuck(other);

        }
    }
}
