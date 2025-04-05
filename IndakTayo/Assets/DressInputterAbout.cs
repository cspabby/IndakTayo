using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressInputterAbout : MonoBehaviour
{
    public GameObject GrabDressPrefab; // Prefab of the GrabDress to instantiate.
    public GameObject AssetDress; // Asset dress to activate.

    void Start()
    {
        // Ensure the AssetDress starts inactive.
        if (AssetDress != null)
            AssetDress.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        // Check if the collision is with a tagged hand object (e.g., "Hand").
        if (other.CompareTag("Hand"))
        {
            if (GrabDressPrefab != null)
            {
                GrabDressPrefab.SetActive(false);

            }

            // Activate the AssetDress to reflect the change visually.
            if (AssetDress != null)
            {
                AssetDress.SetActive(true);
            }
        }
    }

    public void CloneActive()
    {
        GrabDressPrefab.SetActive(true);
    }

  

}