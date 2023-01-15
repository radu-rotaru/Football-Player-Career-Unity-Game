using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateAudioBtnColor : MonoBehaviour
{
    public GameObject audioOptionBtn;

    void Update()
    {
        if (AudioPlayer.isOn)
        {
            audioOptionBtn.GetComponent<Image>().color = new Color32(22, 17, 106, 255);
        }
        else
        {
            audioOptionBtn.GetComponent<Image>().color = new Color32(245, 245, 245, 255);
        }
    }
}
