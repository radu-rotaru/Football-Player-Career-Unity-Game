using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public int CurrentScore;

    public int HighScore;
    // Start is called before the first frame update
    public void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 150, 90), "");

        // Add the score text
        GUI.Label(new Rect(20, 20, 110, 20), "Current Score:"  + CurrentScore);

        // Add the high score text
        GUI.Label(new Rect(20, 40, 110, 20), "High Score: " + HighScore);

        // When the reset button is clicked reset the score
        if (GUI.Button(new Rect(20, 70, 130, 20), "Reset")) {
            CurrentScore = 0;
            HighScore = 0;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
