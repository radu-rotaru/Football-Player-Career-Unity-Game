using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMessage : MonoBehaviour
{

    public GameObject Message;
    void start()
    {
        Message.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("enter");
            Message.SetActive(true);

        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("stay");
            Message.SetActive(true);

        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "WallGoal")
        {
            print("exit");
            Message.SetActive(true);

        }
    }


}
