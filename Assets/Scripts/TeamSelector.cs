using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TeamSelector : MonoBehaviour
{
    [SerializeField]
    public Sprite argImg;
    [SerializeField]
    public Sprite brsImg;
    [SerializeField]
    public Sprite netImg;
    [SerializeField]
    public Sprite gerImg;
    [SerializeField]
    public Sprite crtImg;
    [SerializeField]
    public Sprite frcImg;
    [SerializeField]
    public Sprite engImg;
    [SerializeField]
    public Sprite spnImg;
   
    private GameObject myTeam;
    private GameObject opponentTeam;

    public  int playerTeam = -1;

    private GameObject playMenu ;

    private GameObject teamSelector ;
    GameObject gameObject;
    List<string> myCountryList = new List<string>() { "Argentina", "Brazil", "Croatia", "England", "France", "Germany", "Netherlands", "Spain"};
 
    // Start is called before the first frame update
    private void Awake()
    {
        myTeam = GameObject.Find("MyTeam");
        opponentTeam = GameObject.Find("Opponent");
        playMenu = GameObject.Find("PlayMenu");
        teamSelector = GameObject.Find("TeamSelector");
    }

    int ok = 1, ok1 = 0, ok2 = 0 , ok3 = 0;
    void Start()
    {
       
        if (playerTeam == -1)
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
    void displayTeams()
    {
        
        int position = UnityEngine.Random.Range(1, 8);
        while (position == playerTeam)
            position = UnityEngine.Random.Range(1, 8);
        Debug.Log(playerTeam);
        if (playerTeam == 1)
            myTeam.GetComponent<Image>().sprite = argImg;
        else if (playerTeam == 2)
            myTeam.GetComponent<Image>().sprite = brsImg;
        else if (playerTeam == 3)
            myTeam.GetComponent<Image>().sprite = crtImg;
        else if (playerTeam == 4)
            myTeam.GetComponent<Image>().sprite = engImg;
        else if (playerTeam == 5)
            myTeam.GetComponent<Image>().sprite = frcImg;
        else if (playerTeam == 6)
            myTeam.GetComponent<Image>().sprite = gerImg;
        else if (playerTeam == 7)
            myTeam.GetComponent<Image>().sprite = netImg;
        else if (playerTeam == 8)
            myTeam.GetComponent<Image>().sprite = spnImg;
        else
            myTeam.GetComponent<Image>().sprite = spnImg;

        if (position == 1)
            opponentTeam.GetComponent<Image>().sprite = argImg;
        else if (position == 2)
            opponentTeam.GetComponent<Image>().sprite = brsImg;
        else if (position == 3)
            opponentTeam.GetComponent<Image>().sprite = crtImg;
        else if (position == 4)
            opponentTeam.GetComponent<Image>().sprite = engImg;
        else if (position == 5)
            opponentTeam.GetComponent<Image>().sprite = frcImg;
        else if (position == 6)
            opponentTeam.GetComponent<Image>().sprite = gerImg;
        else if (position == 7)
            opponentTeam.GetComponent<Image>().sprite = netImg;
        else if (position == 8)
            opponentTeam.GetComponent<Image>().sprite = spnImg;

        myCountryList.RemoveAt(position - 1);

    }
    public void Update()
    {
           if(playerTeam != -1 && ok == 1)
        {
            displayTeams();
            ok = 0;
        }

        if (MatchMessage.matchCount == 1 && ok1 == 0)
        {
            displayTeams();
            ok1 = 1;

        }
        else if(MatchMessage.matchCount == 2 && ok2 == 0)
        {
            displayTeams();
            ok2 = 1;
        }
        else if (MatchMessage.matchCount == 3 && ok3 == 0)
        {
            displayTeams();
            ok3 = 1;
        }
           

    }
}
