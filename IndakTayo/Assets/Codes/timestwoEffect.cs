using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timestwoEffect : MonoBehaviour
{
    public GameObject Right;
    public GameObject Left;
    public AudioSource PowerUpSound;
    public TotalPoints totalPoints; // Reference to TotalPoints script

    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && (other.gameObject == Right || other.gameObject == Left))
        {
            StartCoroutine(DoublePoints());
            hasCollided = true;
        }
    }

    private IEnumerator DoublePoints()
    {


        // Activate x2 Points effect globally
        totalPoints.pointsMultiplier = 2; //1 wall is equal to 1 point x 2 = 2 points
        PowerUpSound.Play();
        // Wait for 10 seconds
        yield return new WaitForSeconds(10f); //duration of power up coin


        // Reset points multiplier
        totalPoints.pointsMultiplier = 1;
    }
}
