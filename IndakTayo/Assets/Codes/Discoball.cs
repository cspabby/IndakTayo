using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discoball : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation in degrees per second

    void Update()
    {
        // Calculate the rotation for this frame
        float zRotation = rotationSpeed * Time.deltaTime;

        // Apply the rotation to the GameObject around the Z-axis
        transform.Rotate(0, zRotation, 0);
    }
}
