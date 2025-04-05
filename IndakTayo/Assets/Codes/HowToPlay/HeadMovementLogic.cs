using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeadMovementLogic : MonoBehaviour
{
    public GameObject cameraHead;
    public TextMeshProUGUI textComponent; // LOOK UP
    public TextMeshProUGUI textComponent2;  // LOOK DOWN
    public TextMeshProUGUI textComponent3; //LOOK RIGHT
    public TextMeshProUGUI textComponent4;  //LOOK LEFT
    public TextMeshProUGUI textComponent5;    //TILT TO THE LEFT
    public TextMeshProUGUI textComponent6;   //TILT TO THE RIGHT

    // icons
    public GameObject lookupicon;
    public GameObject lookdownicon;
    public GameObject lookrighticon;
    public GameObject looklefticon;
    public GameObject tiltlefticon;
    public GameObject tiltrighticon;

    // Start is called before the first frame update
    void Start()
    {
        lookupicon.SetActive(false);
        lookdownicon.SetActive(false);
        lookrighticon.SetActive(false);
        looklefticon.SetActive(false);
        tiltlefticon.SetActive(false);
        tiltrighticon.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the Euler angles from the rotation quaternion
        float xRotation = cameraHead.transform.rotation.eulerAngles.x;
        float yRotation = cameraHead.transform.rotation.eulerAngles.y;
        float zRotation = cameraHead.transform.rotation.eulerAngles.z;
        Debug.Log("x: " + xRotation + " y: " + yRotation + " z: " + zRotation);

        //PITCH
        // LOOK UP
        if (xRotation >= 300f && xRotation <= 320f)
        {
            if (textComponent != null)
            {
                textComponent.color = Color.green;
                lookupicon.SetActive(true);
            }
        }
        //PITCH
        // LOOK DOWN
        else if (xRotation >= 60f && xRotation <= 75f)
        {
            if (textComponent2 != null)
            {
                textComponent2.color = Color.green;
                lookdownicon.SetActive(true);
            }
        }

        //YAW
        //LOOK RIGHT
        else if (yRotation >= 100f && yRotation <= 110f)
        {
            if (textComponent3 != null)
            {
                textComponent3.color = Color.green;
                lookrighticon.SetActive(true);
            }
        }
        //YAW
        //LOOK LEFT
        else if (yRotation >= 250f && yRotation <= 260f)
        {
            if (textComponent4!= null)
            {
                textComponent4 .color = Color.green;
                looklefticon.SetActive(true);
            }
        }

        //ROLL
        //TILT TO THE LEFT
        else if (zRotation >= 70f && zRotation <= 80f)
        {
            if (textComponent5 != null)
            {
                textComponent5.color = Color.green;
                tiltlefticon.SetActive(true);
            }
        }
        //ROLL
        //TILT TO THE RIGHT
        else if (zRotation >= 270f && zRotation <= 300f)

            if (textComponent6 != null)
            {
                textComponent6.color = Color.green;
                tiltrighticon.SetActive(true);
            }
    }
    
}
