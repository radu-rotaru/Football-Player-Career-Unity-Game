using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;

public class GoalMessage : MonoBehaviour
{
    public GameObject Message;
    public static bool scored = false;
    private float timeElapsed = 0f;
    private float delayBeforeLoading = 3.0f;
    private string sceneToLoad = "MatchMessage";
   
    void Start()
    {
        scored = false;
        Message.SetActive(false);
    }

    void Update()
    {
        if (scored)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > delayBeforeLoading)
            {
                Shooting.hasShot = false;
                Direction.chosen = false;
                PowerUp.chosen = false;
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

            scored = true;
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("stay");
            Message.SetActive(true);

            scored = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("exit");
            Message.SetActive(true);

            scored = true;
        }
    }
}
