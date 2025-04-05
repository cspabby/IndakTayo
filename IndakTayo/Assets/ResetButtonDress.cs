using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ResetButtonDress : MonoBehaviour
{
   


    private AudioSource sound;

    public float delayDuration = 1f;

    public GameObject[] GrabDresses;
    public GameObject[] AssetDresses;
   public DressInputterAbout RestoreDressCode; 
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            Debug.Log("Trigger Entered by Hand"); // Debugging
            ResetDresses();
            RestoreDressCode.CloneActive();
        }
    }

    public void ResetDresses()
    {
        bool changesMade = false;

        foreach (GameObject grabDress in GrabDresses)
        {
            if (grabDress != null && !grabDress.activeSelf)
            {
                grabDress.SetActive(true);
                changesMade = true;
            }
        }

        foreach (GameObject assetDress in AssetDresses)
        {
            if (assetDress != null && assetDress.activeSelf)
            {
                assetDress.SetActive(false);
                changesMade = true;
            }
        }

        if (changesMade)
        {
            Debug.Log("State changes applied.");
            PlaySound();
        }
        else
        {
            Debug.Log("No state changes made.");
        }
    }

    private void PlaySound()
    {
        if (sound != null)
        {
            sound.Play();
        }
    }
}
