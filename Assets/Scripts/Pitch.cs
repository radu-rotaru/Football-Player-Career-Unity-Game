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
    private float maxScore = 60.0f;
    public static bool finished = false;
    private int levelStep = 30;

    void Start()
    {
        menu = GameObject.Find("Menu");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(menu.GetComponent<Menu>().score > 0)
        {
            MatchMessage.playerScenes = 1 + Convert.ToInt32(Math.Floor(Math.Min(maxScore, menu.GetComponent<Menu>().score) / levelStep));
            trainingMessage.GetComponent<TextMeshProUGUI>().text = $"Final score: {menu.GetComponent<Menu>().score}";
            finished = true;
        }
    }
}
