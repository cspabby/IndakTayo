using UnityEngine;
using UnityEngine.UI;
public class BrightnessOverallScript : MonoBehaviour
{
    [SerializeField] private Slider brightnessSlider; // Reference to the brightness slider
    private static float globalBrightness = 1f; // Default global brightness value

    private void Start()
    {
        // Set up slider with initial values
        if (brightnessSlider != null)
        {
            brightnessSlider.minValue = 0.2f; // Minimum brightness
            brightnessSlider.maxValue = 1f;  // Maximum brightness
            brightnessSlider.value = globalBrightness; // Set slider to the current brightness

            brightnessSlider.onValueChanged.AddListener(SetGlobalBrightness);
        }
        else
        {
            Debug.LogError("Brightness Slider is not assigned!");
        }

        // Apply saved brightness when the scene loads
        ApplyBrightness();
    }

    private void SetGlobalBrightness(float value)
    {
        globalBrightness = value; // Update the static brightness value
        ApplyBrightness();

        Debug.Log($"Global Brightness Set To: {globalBrightness}");
    }

    private void ApplyBrightness()
    {
        // Adjust ambient lighting intensity for the entire scene
        RenderSettings.ambientIntensity = globalBrightness;
    }

}
