using System.Collections;
using TMPro;
using UnityEngine;

public class HTPViewMovementControl : MonoBehaviour
{
    public GameObject MovementCanvas;
    public GameObject GamePlayCanvas;

    public GameObject checkGameplay;
    public GameObject checkMovement;

    void Start()
    {
        checkGameplay.SetActive(false);
        checkMovement.SetActive(false);
    }

    private void Update()
    {

        // Check MovementCanvas independently
        if (MovementCanvas != null && MovementCanvas.activeSelf)
        {

            checkMovement.SetActive(true);
        }

        // Check GamePlayCanvas independently
        if (GamePlayCanvas != null && GamePlayCanvas.activeSelf)
        {

            checkGameplay.SetActive(true);
        }
    }
}
