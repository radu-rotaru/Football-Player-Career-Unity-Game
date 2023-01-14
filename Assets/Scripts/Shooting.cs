using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public static Vector3 direction;
    public static float power;
    public static bool isShooting = false;
    public static bool hasShot = false;

    void Update()
    {
        if (isShooting && !hasShot)
        {
            hasShot = true;
            isShooting = false;
            shoot();
        }
    }


    void shoot()
    {
        direction.y = 0.3f;
        GetComponent<Rigidbody>().AddForce(direction * power, ForceMode.Impulse);
    }
}
