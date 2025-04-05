using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsHTP : MonoBehaviour
{
    public GameObject welcomeCanvas;
    public GameObject ViewCheckList;
    //public GameObject ProceedDance;
    public float switchDelayWelcome = 10f;



    private void Start()
    {
        // Ensure both canvases start in the desired state
        ShowWelcomeCanvas();
        StartCoroutine(SwitchCanvasAfterDelay());

    }

    public void ShowWelcomeCanvas()
    {
        welcomeCanvas.SetActive(true);
        ViewCheckList.SetActive(false);
        //ProceedDance.SetActive(false);


    }


    public void ShowViewCheckList()
    {
        welcomeCanvas.SetActive(false);
        ViewCheckList.SetActive(true);
        //ProceedDance.SetActive(false);

    }

    ////public void ShowProceedDancesCanvas()
    ////{
    ////    welcomeCanvas.SetActive(false);
    ////    ViewCheckList.SetActive(false);
    ////    ProceedDance.SetActive(true);

    ////}  // Start is called before the first frame update

    public void HideAllCanvas()
    {
        {
            welcomeCanvas.SetActive(false);
            ViewCheckList.SetActive(false);
            //ProceedDance.SetActive(false);
        }
    }

    private IEnumerator SwitchCanvasAfterDelay()
    {
        // Wait for the specified time
        yield return new WaitForSeconds(switchDelayWelcome);

        // Switch to the TVCanvas
        ShowViewCheckList();
    }

}
