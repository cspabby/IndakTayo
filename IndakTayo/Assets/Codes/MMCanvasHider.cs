using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMCanvasHider : MonoBehaviour
{
    public GameObject CanvasHide;
    public GameObject CanvasShow;

    // Method to hide the Canvas
    public void HideCanvas()
    {
        if (CanvasHide != null)
        {
            CanvasHide.SetActive(false);
            CanvasShow.SetActive(true);
        }
    }
}
