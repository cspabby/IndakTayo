using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttemptsIncrement : MonoBehaviour
{
    // Track the attempts of the player
    public AttemptsValue attempts;
    // Start is called before the first frame update
    void Start()
    {
        attempts.SetNumberOfAttempts();
    }

    // Update is called once per framesssss
    void Update()
    {
        
    }
}
