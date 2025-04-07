using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowResults : MonoBehaviour
{
    public GameObject MaleWall;
    public GameObject FemaleWall;
    public GameObject ResultsCanvas;
    public AudioSource Congratulations;

    public StopWatch stopWatch;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == MaleWall || other.gameObject == FemaleWall) //Male and Female
        {
            StartCoroutine(ShowResultsWithDelay()); //Coroutine script line
        }
    }

    IEnumerator ShowResultsWithDelay()
    {
        yield return new WaitForSeconds(2f);  // Wait for 2 seconds code
        if (!Congratulations.isPlaying) // Check if the sound isn't already playing
            {
                Congratulations.Play(); //Play the congratulaions audio
            }
        stopWatch.StopEverything(); //for stopwatch stop evrything
        ResultsCanvas.SetActive(true);  // Show the Results Canvas
    }
}
