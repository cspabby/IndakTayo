using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongIndicator : MonoBehaviour
{
    public GameObject Wrong;
    public GameObject Perfect;
    public GameObject Nothing;

    void Start()
    {
        Nothing.SetActive(false);
    }

    public void ShowWrong()
    {
        Wrong.SetActive(true);
        Perfect.SetActive(false);
        Nothing.SetActive(false);
    }

    public void ShowPerfect()
    {
        Wrong.SetActive(false);
        Perfect.SetActive(true);
        Nothing.SetActive(false);
    }
}
