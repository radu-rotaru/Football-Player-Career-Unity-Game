using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            transform.Translate(-Vector3.forward * 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Translate(Vector3.forward * 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            transform.Translate(Vector3.up * 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.V))
        {
            transform.Translate(-Vector3.up * 3f * Time.deltaTime);
        }
    }
}
