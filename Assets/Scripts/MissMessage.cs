using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class MissMessage : MonoBehaviour
{

    public GameObject Message;
    public GameObject missedChanceAudio;
    private bool missed = false;
    private float timeElapsedScene = 0f;
    private float timeElapsedMiss = 0f;
    private float delayBeforeLoading = 3.2f;
    private float delayBeforeMiss = 3.0f;
    private string sceneToLoad = "MatchMessage";

    void start()
    {
        Message.SetActive(false);
    }

    void Update()
    {
        if (Shooting.hasShot && !missed && !GoalMessage.scored)
        {  
            timeElapsedMiss += Time.deltaTime;
            if (timeElapsedMiss >= delayBeforeMiss)
            {
                Message.SetActive(true);
                AudioPlayer.playAudio(missedChanceAudio.GetComponent<AudioSource>(), 7.0f);
                missed = true;
            }
        }
        else if(missed) {
            timeElapsedScene += Time.deltaTime;
            if(timeElapsedScene >= delayBeforeLoading)
            {
                Shooting.hasShot = false;
                Direction.chosen = false;
                PowerUp.chosen = false;
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}