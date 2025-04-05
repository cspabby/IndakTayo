using UnityEngine;

public class GameMechanicsManager : MonoBehaviour
{
    public GameObject[] gameMechanicsCanvases;
    public GameObject SelectDifficultyCanvas;
    public CanvasController canvasController; // Reference to stop coroutine

    private int currentIndex = 0;
    private bool hasFinished = false;

    public void ShowNextGameMechanicsCanvas()
    {
        if (hasFinished) return;

        // Stop the coroutine in CanvasController when the button is clicked
        canvasController.StopAutoSwitching();

        if (currentIndex < gameMechanicsCanvases.Length - 1)
        {
            gameMechanicsCanvases[currentIndex].SetActive(false);
            currentIndex++;
            gameMechanicsCanvases[currentIndex].SetActive(true);
        }
        else
        {
            // Hide all game mechanics canvases
            foreach (GameObject canvas in gameMechanicsCanvases)
            {
                canvas.SetActive(false);
            }

            // Activate Select Difficulty canvas
            SelectDifficultyCanvas.SetActive(true);
            hasFinished = true;
        }
    }
}



  //  public void ShowPreviousGameMechanicsCanvas() back button code
  //  {
   //     if (currentIndex > 0)
  //      {
//            gameMechanicsCanvases[currentIndex].SetActive(false);
///            currentIndex--;
  //          gameMechanicsCanvases[currentIndex].SetActive(true);
 //       }
 //       else
 //       {
            // If at the first screen, go back to welcome
   //         gameMechanicsCanvases[currentIndex].SetActive(false);
          
   //     }
//    }

