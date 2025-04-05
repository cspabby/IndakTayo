using System.Collections;
using TMPro;
using UnityEngine;

public class HTPViewMovementControl : MonoBehaviour
{
    public GameObject MovementCanvas;
    public GameObject GamePlayCanvas;
    public TextMeshProUGUI textComponent1; // Linked to Movement
    public TextMeshProUGUI textComponent2; // Linked to Gameplay
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
        if (MovementCanvas != null && MovementCanvas.activeSelf && textComponent1.color != null)
        {
            textComponent1.color = Color.green;
            checkMovement.SetActive(true);
        }

        // Check GamePlayCanvas independently
        if (GamePlayCanvas != null && GamePlayCanvas.activeSelf && textComponent2.color != null)
        {
            textComponent2.color = Color.green;
            checkGameplay.SetActive(true);
        }
    }
}
