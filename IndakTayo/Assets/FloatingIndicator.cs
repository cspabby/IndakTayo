using UnityEngine;

public class FloatingIndicator : MonoBehaviour
{
    public GameObject TV;
    public float floatSpeed = 1f;
    public float floatAmplitude = 0.5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;

        if (TV == null)
        {
            Debug.LogWarning("TV GameObject is not assigned in FloatingIndicator!");
        }
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
