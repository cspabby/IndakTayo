using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public GameObject GameMechanicsCanvas1;
    public GameObject GameMechanicsCanvas2;
    public GameObject GameMechanicsCanvas3;
    public GameObject GameMechanicsCanvas4;
    public GameObject SelectDifficultyCanvas;
    public GameObject CharacterSelectionCanvas;

      private Coroutine switchCoroutine;
    void Start()
    {
        ShowWelcomeCanvas();
    switchCoroutine = StartCoroutine(SwitchCanvasesWithDelay());

    }

    private void ShowWelcomeCanvas()
    {
        WelcomeCanvas.SetActive(true);
        GameMechanicsCanvas1.SetActive(false);
        GameMechanicsCanvas2.SetActive(false);
        GameMechanicsCanvas3.SetActive(false);
        GameMechanicsCanvas4.SetActive(false);
        SelectDifficultyCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowGameMechanicsCanvas1()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas1.SetActive(true);
        GameMechanicsCanvas2.SetActive(false);
        GameMechanicsCanvas3.SetActive(false);
        GameMechanicsCanvas4.SetActive(false);
        SelectDifficultyCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowGameMechanicsCanvas2()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas1.SetActive(false);
        GameMechanicsCanvas2.SetActive(true);
        GameMechanicsCanvas3.SetActive(false);
        GameMechanicsCanvas4.SetActive(false);
        SelectDifficultyCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowGameMechanicsCanvas3()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas1.SetActive(false);
        GameMechanicsCanvas2.SetActive(false);
        GameMechanicsCanvas3.SetActive(true);
        GameMechanicsCanvas4.SetActive(false);
        SelectDifficultyCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowGameMechanicsCanvas4()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas1.SetActive(false);
        GameMechanicsCanvas2.SetActive(false);
        GameMechanicsCanvas3.SetActive(false);
        GameMechanicsCanvas4.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowSelectDifficultyCanvas()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas1.SetActive(false);
        GameMechanicsCanvas2.SetActive(false);
        GameMechanicsCanvas3.SetActive(false);
        GameMechanicsCanvas4.SetActive(false);
        SelectDifficultyCanvas.SetActive(true);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowCharacterSelectionCanvas()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas1.SetActive(false);
        GameMechanicsCanvas2.SetActive(false);
        GameMechanicsCanvas3.SetActive(false);
        GameMechanicsCanvas4.SetActive(false);
        SelectDifficultyCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(true);
    }

    
       public void StopAutoSwitching()
    {
        if (switchCoroutine != null)
        {
            StopCoroutine(switchCoroutine);
            switchCoroutine = null;
        }
    }


    private IEnumerator SwitchCanvasesWithDelay()
    {

         yield return new WaitForSeconds(19f);
         ShowGameMechanicsCanvas1();

          yield return new WaitForSeconds(16f);
         ShowGameMechanicsCanvas2();

         yield return new WaitForSeconds(9f);
         ShowGameMechanicsCanvas3();

         yield return new WaitForSeconds(5.5f);
         ShowGameMechanicsCanvas4();

        yield return new WaitForSeconds(6f);
        ShowSelectDifficultyCanvas();
    }


}
