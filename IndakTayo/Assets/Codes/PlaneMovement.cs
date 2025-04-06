using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public SpeedController speedController; // Reference to the SpeedController script that handles movement speed

    void Update()
    {
        // Move the object along the x-axis at the speed defined in SpeedController
        // Time.deltaTime ensures smooth movement regardless of frame rate
        transform.position += new Vector3(speedController.speed * Time.deltaTime, 0, 0);
    }
}
