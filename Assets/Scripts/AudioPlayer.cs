using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public static bool isOn = true;

    public static void changeAudioOption()
    {
        isOn = !isOn;
    }

    public static void playAudio(AudioSource audio, float time)
    {
        if(isOn)
        {
            audio.time = time;
            audio.Play();
        }
    }
}
