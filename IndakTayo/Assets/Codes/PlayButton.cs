using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;


public class PlayButton : MonoBehaviour
{
    public GameObject button;  // Reference to the button GameObject
    public UnityEvent onPress; // Events triggered on button press and release
    public UnityEvent onRelease;
    public TextMeshProUGUI buttonText;  // UI components for the button and video display
    public MeshRenderer videoCanvas;  // UI components for the button and video display
    public VideoPlayer videoPlayer;  // UI components for the button and video display
    AudioSource sound;  // Audio source for sound effects
    bool isPlaying;  // Flags for video playback and button interaction
    bool canPressButton = true;  // Flags for video playback and button interaction
    public float delayDuration = 1f;  // Delay duration before button can be pressed again
     // UI elements for additional feedback
    public TextMeshProUGUI textComponent;
    public GameObject checkIcon;

    // public GameObject HintDestroy;

    void Start()
    {
        // Initialize and set the video canvas to inactive
        videoCanvas.gameObject.SetActive(false);
        sound = GetComponent<AudioSource>();
        isPlaying = false;
        buttonText.text = "START";

        // Subscribe to the video loop point event
        videoPlayer.loopPointReached += OnVideoEnd;
        checkIcon.SetActive(false);
    }

    // Triggered when button is pressed
    private void OnTriggerEnter(Collider other)
    {
        // Toggle video playback state when the button is pressed
        if (canPressButton)
        {
            ToggleVideoPlayback();
            StartCoroutine(DelayButtonPress());
        }
    }

    // Prevent multiple presses by adding a delay
    private IEnumerator DelayButtonPress()
    {
        canPressButton = false;
        yield return new WaitForSeconds(delayDuration);
        canPressButton = true;
    }
    // Toggles video playback (start/stop) and updates button state
    private void ToggleVideoPlayback()
    {
        if (!isPlaying)
        {
            onPress.Invoke(); // Trigger the onPress event
            sound.Play(); // Play sound
            StartCanvasVideo(); // Start the video
            isPlaying = true;
            buttonText.text = "STOP";
        }
        else
        {
            sound.Play();
            onRelease.Invoke(); // Trigger the onRelease event
            StopCanvasVideo(); // Stop video playback
            isPlaying = false;
            buttonText.text = "START";
        }
    }

     // Starts the video playback and displays the video canvas
    public void StartCanvasVideo()
    {
        videoCanvas.gameObject.SetActive(true);
        videoPlayer.Play();

       //1 Destroy(HintDestroy);
    }
    // Stops the video playback and hides the video canvas
    public void StopCanvasVideo()
    {
        videoPlayer.Stop();
        videoCanvas.gameObject.SetActive(false);
    }

    // Handles the video end event, updates button text and shows feedback
    private void OnVideoEnd(VideoPlayer vp)
    {
        // Video has finished playing, reset button text to "START"

        videoPlayer.Stop();
        videoCanvas.gameObject.SetActive(false);
        buttonText.text = "START";
        textComponent.color = Color.green;
        checkIcon.SetActive(true);



    }

        // Unsubscribe from the loopPointReached event when the script is destroyed
        private void OnDestroy()
    {
        videoPlayer.loopPointReached -= OnVideoEnd;
    }
}
