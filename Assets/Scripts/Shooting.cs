using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public static Vector3 direction;
    public static float power;
    public static bool isShooting = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isShooting = true;
            shoot();
        }         
    }


    void shoot()
    {
        direction.y = 0.3f;
        GetComponent<Rigidbody>().AddForce(direction * power, ForceMode.Impulse);
    }
}
