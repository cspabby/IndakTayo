using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageShow : MonoBehaviour
{
    public GameObject ConcertStage;
    public GameObject VillageStage;
    public GameObject BallroomStage;
    public GameObject ConcertSkybox;
    public GameObject VillageSkybox;
    public GameObject BallroomSkybox;

    public GameObject screen;
    public GameObject VillageScreen;
    public GameObject BallroomScreen;

    // Update is called once per frame
    void Update()
    {
        string stage = PlayerPrefs.GetString("stage");

        if (stage == "Concert")
        {
            ConcertStage.SetActive(true);
            ConcertSkybox.SetActive(true);
        }
        else if (stage == "Village")
        {
            VillageStage.SetActive(true);
            VillageSkybox.SetActive(true);
            if (VillageScreen != null)
            {
                screen.transform.position = VillageScreen.transform.position; // Copy Position
                screen.transform.rotation = VillageScreen.transform.rotation; // Copy Rotation
                screen.transform.localScale = VillageScreen.transform.localScale; // Copy Scale
            }
            else
            {
                Debug.LogWarning("VillageScreen is not assigned in the Inspector!"); //log warning for village
            }

        }
        else if (stage == "Ballroom")
        {
            BallroomStage.SetActive(true);
            BallroomSkybox.SetActive(true);
            if (BallroomScreen != null)
            {
                screen.transform.position = BallroomScreen.transform.position; // Copy position
                screen.transform.rotation = BallroomScreen.transform.rotation; // Copy rotation
                screen.transform.localScale = BallroomScreen.transform.localScale; // Copy scale
            }
            else
            {
                Debug.LogWarning("BallroomScreen is not assigned in the Inspector!"); //
            }
        }
    }
}
