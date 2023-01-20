using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowLeaderboard : MonoBehaviour
{
    public GameObject leaderboard;

    void Start()
    {
        string winners = PlayerPrefs.GetString("Winners");

        if (winners.Length != 0)
        {
            leaderboard.GetComponent<TextMeshProUGUI>().text = "Winners:\n" + winners.Replace(",", "\n");
        }
    }
}
