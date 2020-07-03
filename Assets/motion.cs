using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class motion : MonoBehaviour
{
    // Light infoCube;
    // infoCube = GetComponent<infoCube>(); //<游戏物体名称> exp: static function Exp (power : float) : float

    public GameObject object1;
    // Camera m_MainCamera;
    private int[] mark = new int[13];

    // Start is called before the first frame update
    void Start()
    {
        // m_MainCamera = Camera.main;
        transform.position=new Vector3(0,0,-4600);

        for (int i = 0; i < 13; i++)
        {
            mark[i]=0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int t = (int)Math.Floor(Time.time/3);
        if (t>=13) return;

        if(mark[t] == 0) {    
            int number = (int)Math.Round(Math.Pow(2,t));

		    for (int i = 0; i < number; i++)  {
			    Vector3 p = UnityEngine.Random.insideUnitSphere*40;  //乘上球体半径
                Instantiate(object1,new Vector3(p.x,p.y,p.z+140*t-4500),UnityEngine.Random.rotation);
		    }

            mark[t]=1;    
            Debug.Log(string.Format("t is {0}",t));
        }

        transform.position += new Vector3(0,0,140/3*Time.deltaTime);

        // if(mark[t] == 0) {   
        //     int halfSide= (int)Math.Round(Math.Sqrt(Math.Pow(2,t+3))/2);
        //     for (int i = -halfSide; i <halfSide; i++)
        //     {
        //         for(int j = -halfSide; j <halfSide; j++)
        //         {
        //             Instantiate(object1,new Vector3(i,j,t*5),Quaternion.identity); 
        //         }
        //     }
        //     mark[t]=1;    
        //     Debug.Log(string.Format("t is {0}",t));
        // }
    }
}
