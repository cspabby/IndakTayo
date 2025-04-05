using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drumSound : MonoBehaviour
{
    public AudioBehaviour sound;
    private bool canPlay = true; // Boolean to manage detection cooldown

    public void OnTriggerEnter(Collider other)
    {
        if (canPlay && other.CompareTag("Hand"))
        {
            canPlay = false; // Disable detection
            sound.GetComponentInParent<AudioSource>().Play();
            StartCoroutine(ResetCooldown()); // Start cooldown coroutine
        }
    }

    private IEnumerator ResetCooldown()
    {
        yield return new WaitForSeconds(0.5f); // Wait for 0.5 seconds
        canPlay = true; // Re-enable detection
    }
}
