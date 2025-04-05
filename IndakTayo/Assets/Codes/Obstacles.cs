using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject Head;
    public GameObject Right;
    public GameObject Left;
    public AudioSource ObstacleSounds;
    public TotalPoints points;

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
