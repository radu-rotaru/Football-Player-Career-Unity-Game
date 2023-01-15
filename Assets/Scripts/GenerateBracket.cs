using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using System;
public class GenerateBracket : MonoBehaviour
{
    List<string> myCountryList = new List<string>() { "Argentina", "Brazil", "France", "Croatia", "Netherlands", "Spain", "Germany", "England" };
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public List<string> createBrackets()
    {
        List<string> myBracket = new List<string>();
        int position;
        int count = 8;

        while (true)
        {
            if (count == 1)
            {
                myBracket.Add(myCountryList[0]);
                break;

            }
            position = UnityEngine.Random.Range(0, count);
            myBracket.Add(myCountryList[position]);
            myCountryList.RemoveAt(position);
            count = count - 1;


        }
        return myBracket;
    }
}