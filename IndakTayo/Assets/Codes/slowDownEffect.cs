using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDownEffect : MonoBehaviour
{
    public GameObject Right;
    public GameObject Left;
    public AudioSource PowerUpSound;
    public SpeedController speedController; // Reference to speed controller
    public SelectDifficulty MusicHardEffect;
   
    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && (other.gameObject == Right || other.gameObject == Left)) //either right hand left hand
        {
            StartCoroutine(SlowDownTemporarily());
            hasCollided = true;
        }
    }

    private IEnumerator SlowDownTemporarily()
    {
        // Slow down speed and lower pitch
        speedController.speed = 1f; //speed is set to avreage/normal
      MusicHardEffect.musicNormal.pitch = 1f; //music plays average/normal speed
        PowerUpSound.Play(); //Slow speed clock plays when hit

        // Wait for 10 seconds
        yield return new WaitForSeconds(10f); //duration or effectivity of slow speed clock

        // Reset speed and pitch back to normal
        speedController.speed = 1.5f; //after 10 seconds the hard mode is back
        // ObstacleSounds.pitch = 1.0f; // Reset pitch to default
        MusicHardEffect.musicNormal.pitch = 1.5f;
    }
}
