using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pitch : MonoBehaviour
{
    private GameObject menu;
    public GameObject trainingMessage;
    // the score that gives the max reward, every score higher gives the same result
    private float maxScore = 20.0f;
    public static bool finished = false;
    private int levelStep = 10;

    void Start()
    {
        finished = false;
        menu = GameObject.Find("Menu");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(menu.GetComponent<Menu>().score > 0)
        {
            MatchMessage.playerScenes = 1 + Convert.ToInt32(Math.Floor(Math.Min(maxScore, menu.GetComponent<Menu>().score) / levelStep));
            if(!MatchOptions.godModeOn)
            {
                MatchMessage.playerTeamScenes = 5 - MatchMessage.playerScenes;
            }
        
            trainingMessage.GetComponent<TextMeshProUGUI>().text = $"Final score: {menu.GetComponent<Menu>().score}";
            finished = true;
        }
    }
}
