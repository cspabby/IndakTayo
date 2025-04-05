using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggleXdance : MonoBehaviour
{
    public GameObject canvas;
    public bool isActive = false;
    private bool isScriptActive = true;

    public StopWatch stopWatch; // Reference to the StopWatch script

    private void Start()
    {
        canvas.SetActive(false); // Start with the canvas disabled
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isScriptActive)
            return;

        if (OVRInput.GetDown(OVRInput.Button.Three)) // You can replace this with the Oculus button you want to use.
        {
            isActive = !isActive; // Toggle the isActive flag
            canvas.SetActive(isActive);

            // Call the appropriate method on the StopWatch script
            if (stopWatch != null)
            {
                if (isActive)
                {
                    stopWatch.StopEverything();
                }
                else
                {
                    stopWatch.GoEverything();
                }
            }
            else
            {
                Debug.LogWarning("StopWatch reference is not assigned!");
            }
        }
    }

    // Function to deactivate the script
    public void DeactivateScript()
    {
        isScriptActive = false;
    }
}
