using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDiscoBall : MonoBehaviour
{
    public float rotationSpeed = 50f; // Adjust the speed as needed

    void Update()
    {
        //Rotate the disco ball on its Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
