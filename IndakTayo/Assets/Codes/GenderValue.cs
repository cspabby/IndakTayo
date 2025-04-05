using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenderValue : MonoBehaviour
{
    public TextMeshProUGUI GenderText; 

    void Update()
    {
        // Update the GenderText with the current gender from StartDancee
        GenderText.text = StartDance.GetGender();
    }
}
