using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public static Vector3 direction;

    public static float power;   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }         
    }


    void shoot()
    {
        Vector3 Shoot = (this.transform.position + direction).normalized;
        GetComponent<Rigidbody>().AddForce(Shoot * power, ForceMode.Impulse);
    }
}
