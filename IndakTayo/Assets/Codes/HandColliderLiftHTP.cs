using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HandColliderLiftHTP : MonoBehaviour
{
    public CapsuleCollider HandLeft;
    public CapsuleCollider HandRight;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI textComponent2;



    public void OnTriggerEnter(Collider other)
    {
        // Check if the left hand triggered
        if (other == HandLeft && textComponent != null)
        {
            textComponent.color = Color.green;
    
        }

        // Check if the right hand triggered
        if (other == HandRight && textComponent2 != null)
        {
            textComponent2.color = Color.green;
 
        }

    }
}
