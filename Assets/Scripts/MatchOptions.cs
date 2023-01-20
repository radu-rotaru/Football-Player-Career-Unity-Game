using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchOptions : MonoBehaviour
{
    public static int opScenes = 5;
    public static int playerScenes = 1;
    public static int playerTeamScenes = 5;
    public static bool godModeOn = false;

    public static void changeOption()
    {
        godModeOn = !godModeOn;

        if(godModeOn)
        {
            opScenes = 0;
            playerScenes = 3;
            playerTeamScenes = 3;
        }
        else
        {
            opScenes = 5;
            playerScenes = 1;
            playerTeamScenes = 5;
        }

        MatchMessage.computerScenes = opScenes;
        MatchMessage.playerScenes = playerScenes;
        MatchMessage.playerTeamScenes = playerTeamScenes - playerScenes;
    }
}
