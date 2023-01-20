using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddToLeaderboard : MonoBehaviour
{
    public static void SaveInput(GameObject inputField)
    {
        string winnerName = inputField.GetComponent<TMP_InputField>().text;
        string winners = "";

        if (winnerName.Length > 0)
        {
            winners = PlayerPrefs.GetString("Winners");
            winners += $", {winnerName}";

            PlayerPrefs.SetString("Winners", winners);
            PlayerPrefs.Save();

            inputField.GetComponent<TMP_InputField>().interactable = false;
        }
    }
}
