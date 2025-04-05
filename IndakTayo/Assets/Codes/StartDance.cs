using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDance : MonoBehaviour
{
    public GameObject Steps;
    public GameObject MaleSteps;
    public GameObject FemaleSteps;
    public StepsShow stepsShow;
    public GameObject CharacterSelection;
    public static string GenderText;


    public static string GetGender()
    {
        return GenderText;
    }
    // Start is called before the first frame update
    public void Male()
    {
        GenderText = "Male";
        stepsShow.StartSequence();
        Steps.SetActive(true);
        MaleSteps.SetActive(true);
        FemaleSteps.SetActive(false);
        CharacterSelection.SetActive(false);

    }
    public void Female()
    {
        GenderText = "Female";
        stepsShow.StartSequence();
        Steps.SetActive(true);
        MaleSteps.SetActive(false);
        FemaleSteps.SetActive(true);
        CharacterSelection.SetActive(false);
    }
}
