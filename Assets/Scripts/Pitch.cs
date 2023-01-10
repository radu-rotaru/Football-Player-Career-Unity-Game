using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitch : MonoBehaviour
{
    private GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        menu = GameObject.Find("Menu");
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        menu.GetComponent<Menu>().CurrentScore = 0;
    }
}
