using UnityEngine;
using UnityEngine.UI;


public class SoundsOverAllScript : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider; // Reference to the volume slider

    private void Start()
    {
        if (volumeSlider != null)
        {
            // Ensure slider starts with correct values
            volumeSlider.minValue = 0f; // Left (mute)
            volumeSlider.maxValue = 1f; // Right (full volume)
            volumeSlider.value = 1f; // Start at max volume (slider at right)

            // Add listener for volume adjustment
            volumeSlider.onValueChanged.AddListener(SetOculusVolume);
        }
        else
        {
            Debug.LogError("Volume Slider is not assigned!");
        }
    }

    private void SetOculusVolume(float value)
    {
        // Directly set volume based on slider's value
        AudioListener.volume = value;

        Debug.Log($"Oculus Volume Set To: {value}");
    }
}
