using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// This script controls the visibility of multiple UI objects
/// by activating only one at a time using increment/decrement buttons.
public class MMCanvasMoverButtons : MonoBehaviour
{
    public GameObject[] objectsToMove;
    public int currentIndex = 0;
    private int previousIndex = 0; // Track the previous index
    public GameObject incrementButton;
    public GameObject decrementButton;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize by enabling the first object and disabling the others
        for (int i = 0; i < objectsToMove.Length; i++)
        {
            objectsToMove[i].SetActive(i == 0); // Enable only the first object
        }
    }
    // Method to move objects according to the current index
    void MoveObjects()
    {
        // Disable only the previous object
        objectsToMove[previousIndex].SetActive(false);

        // Enable the current object
        objectsToMove[currentIndex].SetActive(true);

        // Update previous index
        previousIndex = currentIndex;
    }

    // Method to increment the index and move objects to the right
    public void IncrementIndex()
    {
        currentIndex = (currentIndex + 1) % objectsToMove.Length;
        MoveObjects();
    }

    // Method to decrement the index and move objects to the left
    public void DecrementIndex()
    {
          // Decrement the index and ensure it loops back to the end
        currentIndex = (currentIndex - 1 + objectsToMove.Length) % objectsToMove.Length;
        MoveObjects(); // Move objects based on the new index
    }
}
    