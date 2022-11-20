using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoalkeeperDive : MonoBehaviour
{
    public GameObject goalkeeper;

    void Update()
    {
        if (Shooting.isShooting)
        {
            var rnd = new System.Random(DateTime.Now.Millisecond);
            bool dive_dir = rnd.Next(2) == 1;

            if (!dive_dir)
            {
                goalkeeper.GetComponent<Animator>().Play("GoalkeeperDiveLeft");
            }
            else
            {
                goalkeeper.GetComponent<Animator>().Play("GoalkeeperDiveRight");
            }
            
            Shooting.isShooting = false;
        }
    }


}
