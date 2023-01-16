using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public static Vector3 direction;
    public static float power;
    public static bool hasShot = false;

    void Update()
    {
        if (Direction.chosen && PowerUp.chosen && !hasShot)
        {
            hasShot = true;
            shoot();
        }
    }


    void shoot()
    {
        direction.y = 0.3f;
        GetComponent<Rigidbody>().AddForce(direction * power, ForceMode.Impulse);
    }
}
