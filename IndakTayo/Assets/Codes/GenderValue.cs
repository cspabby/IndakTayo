using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenderValue : MonoBehaviour
{
    public TextMeshProUGUI GenderText; //assign the inspector


    void Update()
    {
        // updatee
        GenderText.text = StartDance.GetGender();
    }
}
