using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetFixturePhase : MonoBehaviour
{
    private static string[] phases = { "Quarterfinal", "Semifinal", "Final" };
    public GameObject fixtureText;
    
    void Start()
    {
        fixtureText.GetComponent<TextMeshProUGUI>().text = phases[MatchMessage.matchCount];
    }
}
