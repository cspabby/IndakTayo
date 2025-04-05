using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAttemptsAndDifficulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("attempts", 0);
        PlayerPrefs.SetInt("isHard", 0);
        PlayerPrefs.SetInt("isAverage", 0);
        PlayerPrefs.SetInt("isAverage", 0);
        PlayerPrefs.Save();
    }
}
