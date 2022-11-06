using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
   
    
        public Transform target;

        public float Force;
        
    

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
    Vector3 Shoot = (target.position - this.transform.position).normalized;
    GetComponent<Rigidbody>().AddForce(Shoot * Force + new Vector3(0, 3f, 0), ForceMode.Impulse);
}
}
