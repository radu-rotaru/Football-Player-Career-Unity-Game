using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class GoalMessage : MonoBehaviour
{
    public GameObject Message;
    private bool started = false;
    private float timeElapsed = 0f;
    private float delayBeforeLoading = 3.0f;
    private string sceneToLoad = "MatchMessage";
   
    void start()
    {
        Message.SetActive(false);
    }

    void Update()
    {
        if (started)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > delayBeforeLoading)
            {
                MatchMessage.goalsPlayerTeam += 1;
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("enter");
            Message.SetActive(true);

            started = true;
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("stay");
            Message.SetActive(true);

            started = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("exit");
            Message.SetActive(true);

            started = true;
        }
    }
}
