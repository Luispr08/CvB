using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STap : MonoBehaviour
{
    public GameObject O1; 
    public GameObject O2;
    public GameObject O3;
    public GameObject O4;
    public GameObject O5;

    public GameObject OB1;
    public GameObject OB2;
    public GameObject OB3;
    public GameObject OB4;
    public GameObject OB5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   /* void Update()
    {
        //check if the object spawned.
        O1 = GameObject.Find("S1I");
        O2 = GameObject.Find("S2I");
        O3 = GameObject.Find("S3I");
        O4 = GameObject.Find("S4I");
        O5 = GameObject.Find("S5I");
        if (O1 != null)
        {
            OB1 = O1;
        }
        if (O2 != null)
        {
            OB2 = O2;
        }
        if (O3 != null)
        {
            OB3 = O3;
        }
        if (O4 != null)
        {
            OB4 = O4;
        }
        if (O1 != null)
        {
            OB5 = O5;
        }

       
    }
    public void OnMouseDown()//THE PROBLEM IS THE DESIGNATION OF NAMES AT OX GAMEOBJECT FIND THAT IS THE PROBLEM. FIX IT! 
    {
        string n1 = "";
        string n2 = "";
        string n3 = "";
        string n4 = "";
        string n5 = "";
         var obj = this.gameObject;
        int x = 0;
        if(OB1 !=null)
        {
             n1 = OB1.name;
        }
        if (OB2 != null)
        {
             n2 = OB2.name;
        }
        if (OB3 != null)
        {
            n3 = OB3.name;
        }
        if (OB4 != null)
        {
            n4 = OB4.name;
        }
        if (OB5 != null)
        {
            n5 = OB5.name;
        }
        OB1.name = "";
        OB2.name = "";
        OB3.name = "";
        OB4.name = "";
        OB5.name = "";
        for (x = 0; x < 2; x++)
        {
            OB1.name += n1[x];
            OB2.name += n2[x];
            OB3.name += n3[x];
            OB4.name += n4[x];
            OB5.name += n5[x];

        }
        if (obj.name == OB1.name && obj.tag == OB1.tag)
            {
                //Clicked the correct color
                Debug.Log("right color");
                Destroy(obj.gameObject);
                Destroy(OB1.gameObject);
                SSPawner1.spawnCTRL = true;
                
                OB2.name = n2;
                OB3.name = n3;
                OB4.name = n4;
                OB5.name = n5;

        }
            else if (obj.name == OB2.name && obj.tag == OB2.tag)
            {
                Debug.Log("right color");
                Destroy(obj.gameObject);
                Destroy(OB2.gameObject);
                SSPawner2.spawnCTRL = true;
            OB1.name = n1;
            OB3.name = n3;
            OB4.name = n4;
            OB5.name = n5;

        }
        else if (obj.name == OB3.name && obj.tag == OB3.tag)
            {
                Debug.Log("right color");
                Destroy(obj.gameObject);
                Destroy(OB3.gameObject);
                SSPawner3.spawnCTRL = true;
            OB1.name = n1;
            OB2.name = n2;
            OB4.name = n4;
            OB5.name = n5;

        }
        else if (obj.name == OB4.name && obj.tag == OB4.tag)
            {
                Debug.Log("right color");
                Destroy(obj.gameObject);
                Destroy(OB4.gameObject);
                SSPawner4.spawnCTRL = true;
            OB1.name = n1;
            OB2.name = n2;
            OB3.name = n3;
            OB5.name = n5;

        }
        else if (obj.name == OB5.name && obj.tag == OB5.tag)
            {
                Debug.Log("right color");
                Destroy(obj.gameObject);
                Destroy(OB5.gameObject);
                SSPawner5.spawnCTRL = true;

                OB1.name = n1;
                OB2.name = n2;
                OB3.name = n3;
                OB4.name = n4;
               

        }
        else
            {
                //Player loses.
                Debug.Log("wrong color");
            }
        
    }*/
}
