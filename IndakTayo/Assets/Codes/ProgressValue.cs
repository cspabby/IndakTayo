using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ProgressValue : MonoBehaviour
{
    public TextMeshProUGUI progress;
    public TaskPercentage task;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        // Update the TextMeshPro text with the taskPercentage value
        progress.text = Mathf.FloorToInt(task.TaskPercentageValue) + "/100";
    }
}
