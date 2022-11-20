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
        Vector3 Shoot = (this.transform.position + direction).normalized;
        GetComponent<Rigidbody>().AddForce(Shoot * power, ForceMode.Impulse);
    }
}
