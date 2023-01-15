using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Threading;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public int kickPower = 4;

    private bool clicked;
    private GameObject menu;
    private Rigidbody _rigidbody;
    private string sceneToLoad = "PlayScene";
    private float timeElapsed = 0.0f;
    private float delayBeforeLoading = 3.0f;
    public static bool done = false; 


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        menu=GameObject.Find("Menu");
    }

    void FixedUpdate()
    {
        if (clicked && !Pitch.finished) 
        {
            int x = Random.Range(0,2);
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
            
            menu.GetComponent<Menu>().score += 1;
            
            clicked = false;
        }

        if(Pitch.finished)
        {
            timeElapsed += Time.deltaTime;

            if(timeElapsed > delayBeforeLoading)
            {
                done = true;
                SceneManager.LoadScene(sceneToLoad);
            }
        }
        
    }

    private void OnMouseDown()
    {
        clicked = true;
    }
}

