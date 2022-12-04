using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoalkeeperDiveFromAction : MonoBehaviour
{
    public GameObject goalkeeper;
    public GameObject ball;

    void Update()
    {
        if (Shooting.isShooting)
        {
            Vector2 keeperDirection = new Vector2(goalkeeper.transform.position.x - ball.transform.position.x, goalkeeper.transform.position.z - ball.transform.position.z);
            Vector2 shootingDirection = new Vector2(Shooting.direction.x, Shooting.direction.z);

            Debug.Log(Vector2.Angle(shootingDirection, keeperDirection));

            if (Vector2.Angle(shootingDirection, keeperDirection) > 5.0f)
            {
                goalkeeper.GetComponent<Animator>().Play("GoalkeeperDiveRight");
            }

            Shooting.isShooting = false;
        }
    }


}
