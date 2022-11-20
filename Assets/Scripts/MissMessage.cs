using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissMessage : MonoBehaviour
{

    public GameObject Message;
    void start()
    {
        Message.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "MissWall")
        {
            print("enter");
            Message.SetActive(false);

        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "MissWall")
        {
            print("stay");
            Message.SetActive(true);

        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "MissWall")
        {
            print("exit");
            Message.SetActive(true);

        }
    }


}