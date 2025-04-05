using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HTPHideShowChecker : MonoBehaviour
{
    public Canvas MainCanvasParent;
    public GameObject MainChecklistParent;
    public GameObject QuitCanvas; 
    public TextMeshProUGUI textComponent1; // Main Canvas
    public TextMeshProUGUI textComponent2; //  Main Checklist
    public TextMeshProUGUI textComponent3; //Quit Canvas
    public GameObject checkMainCanvas;
    public GameObject checkChecklist; 
    public GameObject checkQuitCanvas;

    void Start()
    {
        checkMainCanvas.SetActive(false);
        checkChecklist.SetActive(false);
        checkQuitCanvas.SetActive(false);
    }


    private void Update()
    {

        // Main Canvas
        if (MainCanvasParent != null && !MainCanvasParent.enabled && textComponent1.color != null)
        {
            textComponent1.color = Color.green;
            checkMainCanvas.SetActive(true);
        }

        // Main Checklist
        if (MainChecklistParent != null && !MainChecklistParent.activeSelf && textComponent2.color != null)
        {
            textComponent2.color = Color.green;
            checkChecklist.SetActive(true);
        }

        // Quit Canvas
        if (QuitCanvas != null && QuitCanvas.activeSelf && textComponent3.color != null)
        {
            textComponent3.color = Color.green;
            checkQuitCanvas.SetActive(true);
        }
    }
}
