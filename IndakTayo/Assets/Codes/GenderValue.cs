using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GenderValue : MonoBehaviour
{
    public TextMeshProUGUI GenderText; //Assign the inspector


    void Update()
    {
      
        // Update the GenderText with the current gender from StartDance
        GenderText.text = StartDance.GetGender();
    }
}
