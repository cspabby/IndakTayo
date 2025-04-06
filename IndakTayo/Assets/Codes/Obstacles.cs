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

    private bool hasCollided = false; // Flag to prevent multiple collisions

    // Trigger method for detecting collision with specific objects (Head, Right, or Left)
    private void OnTriggerEnter(Collider other)
    {
         // Check if there was no prior collision and the collided object is one of the specified ones
        if (!hasCollided && (other.gameObject == Head || other.gameObject == Right || other.gameObject == Left))
        {
            // Decrease points by 1 upon collision
            points.DecrementPoints(1);
             // Play collision sound
            ObstacleSounds.Play();
            hasCollided = true;
        }
    }
}
