using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    // References to the player's head, right, and left parts
    public GameObject Head;
    public GameObject Right;
    public GameObject Left;
    public AudioSource ObstacleSounds; // Sound played upon collision with the obstacle
    public TotalPoints points;  // Reference to the points manager

    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && (other.gameObject == Head || other.gameObject == Right || other.gameObject == Left))
        {
            points.DecrementPoints(1);
            ObstacleSounds.Play();
            hasCollided = true;
        }
    }
}
