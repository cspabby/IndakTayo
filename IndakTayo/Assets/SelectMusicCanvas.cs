using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMusicCanvas : MonoBehaviour
{
    public GameObject JotabalCanvas;
    public GameObject PolkabalCanvas;
    public GameObject MainMenu;

    void Start()
    {
        JotabalCanvas.SetActive(false);
        PolkabalCanvas.SetActive(false);
    }

    public void OpenJotabalCanvas()
    {
        MainMenu.SetActive(false);
        JotabalCanvas.SetActive(true);
        PolkabalCanvas.SetActive(false);
    }

    public void OpenPolkabalCanvas()
    {
        MainMenu.SetActive(false);
        JotabalCanvas.SetActive(false);
        PolkabalCanvas.SetActive(true);
    }
}
