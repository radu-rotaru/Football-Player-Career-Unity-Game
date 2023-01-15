using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeamSelector : MonoBehaviour
{

    public int playerTeam;

    private GameObject playMenu ;

    private GameObject teamSelector ;
    // Start is called before the first frame update
    private void Awake()
    {
        playMenu = GameObject.Find("PlayMenu");
        teamSelector = GameObject.Find("TeamSelector");
    }

    void Start()
    {
        
        if (playerTeam==-1)
        {
            playMenu.SetActive(false);
            teamSelector.SetActive(true);
        }
        else
        {
            playMenu.SetActive(true);
            teamSelector.SetActive(false);
        }
    }
    public void changeTeam(int id)
    {
        playerTeam = id;
        playMenu.SetActive(true);
        teamSelector.SetActive(false);
    }

   
    
}
