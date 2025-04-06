using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public SpeedController speedController; // Reference to the SpeedController script that handles movement speed

    void Update()
    {
        // Move the object along the x-axis at the speed defined in SpeedController
        transform.position += new Vector3(speedController.speed * Time.deltaTime, 0, 0);
    }
}
