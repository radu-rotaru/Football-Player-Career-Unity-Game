using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Click : MonoBehaviour
{
    public int kickPower = 4;

    private bool clicked;
    private GameObject menu;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        menu=GameObject.Find("Menu");
    }

    void FixedUpdate()
    {
        if (clicked)
        {
            int x =Random.Range(0,2);
            int y = Random.Range(1, 40);
            if(x==0)
            {
                _rigidbody.AddForce(Vector3.up * (kickPower * 100));
                _rigidbody.AddForce(Vector3.left * (kickPower * y) );
            }
            else
            {
                _rigidbody.AddForce(Vector3.up * (kickPower * 100));
                _rigidbody.AddForce(Vector3.right * (kickPower * y) );
            }
            menu.GetComponent<Menu>().CurrentScore += 1;
            if (menu.GetComponent<Menu>().CurrentScore > menu.GetComponent<Menu>().HighScore) {
                menu.GetComponent<Menu>().HighScore = menu.GetComponent<Menu>().CurrentScore;
            }

            clicked = false;
        }
        
    }

    private void OnMouseDown()
    {
        clicked = true;
    }
}

