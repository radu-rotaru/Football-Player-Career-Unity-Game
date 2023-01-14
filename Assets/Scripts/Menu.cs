using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    public void OnGUI()
    {
        GUI.skin.label.fontSize = 50;

        GUI.Box(new Rect(10, 10, 250, 190), "");

        // Add the score text
        GUI.Label(new Rect(20, 20, 210, 120), "Score:"  + score);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
