using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuarterBracket : MonoBehaviour
{
    GameObject c1;
    GameObject c2;
    GameObject c3;
    GameObject c4;
    GameObject c5;
    GameObject c6;
    GameObject c7;
    GameObject c8;
    [SerializeField] GameObject gen;
    public Vector3 anchoredPosition3D;

    List<string> bracket;
    // Start is called before the first frame update
    void Start()
    {
        //generateBracket = gen.GetComponent<GenerateBracket>();
        bracket = createBrackets();
        c1 = GameObject.FindWithTag(bracket[0]);
        c2 = GameObject.FindWithTag(bracket[1]);
        c3 = GameObject.FindWithTag(bracket[2]);
        c4 = GameObject.FindWithTag(bracket[3]);
        c5 = GameObject.FindWithTag(bracket[4]);
        c6 = GameObject.FindWithTag(bracket[5]);
        c7 = GameObject.FindWithTag(bracket[6]);
        c8 = GameObject.FindWithTag(bracket[7]);

        c1.transform.position = new Vector3(235, -177, 0);
        c2.transform.position = new Vector3(595, -177, 0);
        c3.transform.position = new Vector3(955, -177, 0);
        c4.transform.position = new Vector3(1315, -177, 0);
        c5.transform.position = new Vector3(235, -457, 0);
        c6.transform.position = new Vector3(595, -457, 0);
        c7.transform.position = new Vector3(955, -457, 0);
        c8.transform.position = new Vector3(1315, -457, 0);
        Debug.Log(bracket[0]);
    }
    List<string> myCountryList = new List<string>() { "Argentina", "Brazil", "France", "Croatia", "Netherlands", "Spain", "Germany", "England" };

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
    // Update is called once per frame
    void Update()
    {

       

    }
}