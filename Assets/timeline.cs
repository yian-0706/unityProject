using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class timeline : MonoBehaviour
{
    public Text text;
    // private int[] mark = new int[13];
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // int t = (int)Math.Floor(Time.time/3);
        // if (t>=13) return;

        // if(mark[t] == 0) {    
            int year = (int)Math.Floor(Time.time/3*25+1695); //1720+t*25;
            if(year>2020) year = 2020;
            text.text = year.ToString();
            
            // mark[t]=1;    
        // }

        
    }
}
