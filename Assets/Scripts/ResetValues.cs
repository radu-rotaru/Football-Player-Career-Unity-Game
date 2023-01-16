using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValues : MonoBehaviour
{
    public void reset()
    {
        MatchMessage.matchCount = 0;
        TeamSelector.position = -1;
        TeamSelector.playerTeam = -1;
        TeamSelector.quarterPosition = -1;
        TeamSelector.semiFinalPosition = -1;

    }
}
