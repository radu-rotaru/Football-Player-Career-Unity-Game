using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderScript : MonoBehaviour
{
    public GameObject defender;
    private bool done = false;

    void Update()
    {
        if (!done && Shooting.hasShot)
        {
            defender.GetComponent<Animator>().Play("Tackle");
            done = true;
            /*Shooting.hasShot = false;*/
        }
    }
}
