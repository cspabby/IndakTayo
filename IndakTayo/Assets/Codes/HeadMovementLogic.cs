using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeadMovementLogic : MonoBehaviour
{
    public GameObject cameraHead;
 
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
            if (lookupicon != null)
            {
                lookupicon.SetActive(true);
            }
        }
        //PITCH
        // LOOK DOWN
        else if (xRotation >= 60f && xRotation <= 75f)
        {
            if (lookdownicon != null)
            {
                lookdownicon.SetActive(true);
            }
        }

        //YAW
        //LOOK RIGHT
        else if (yRotation >= 100f && yRotation <= 110f)
        {
            if (lookrighticon != null)
            {
                lookrighticon.SetActive(true);
            }
        }
        //YAW
        //LOOK LEFT
        else if (yRotation >= 250f && yRotation <= 260f)
        {
            if (looklefticon!= null)
            {
                looklefticon.SetActive(true);
            }
        }

        //ROLL
        //TILT TO THE LEFT
        else if (zRotation >= 70f && zRotation <= 80f)
        {
            if (tiltlefticon != null)
            {
                tiltlefticon.SetActive(true);
            }
        }
        //ROLL
        //TILT TO THE RIGHT
        else if (zRotation >= 270f && zRotation <= 300f)

            if (tiltrighticon != null)
            {
                tiltrighticon.SetActive(true);
            }
    }
    
}
