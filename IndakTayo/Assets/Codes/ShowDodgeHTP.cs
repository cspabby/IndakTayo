using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDodgeHTP : MonoBehaviour
{
    public StepShowHTP ShowDancePass;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ShowDancePass.ShowDanceDodge(other);

        }
    }
}
