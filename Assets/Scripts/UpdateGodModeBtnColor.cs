using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGodModeBtnColor : MonoBehaviour
{
    public GameObject godModeOptionBtn;

    void Update()
    {
        if (MatchOptions.godModeOn)
        {
            godModeOptionBtn.GetComponent<Image>().color = new Color32(22, 17, 106, 255);
        }
        else
        {
            godModeOptionBtn.GetComponent<Image>().color = new Color32(245, 245, 245, 255);
        }
    }
}
