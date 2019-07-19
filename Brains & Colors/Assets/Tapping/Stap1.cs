using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stap1 : MonoBehaviour
{
    public GameObject Identifier1;
    public GameObject Identifier2;
    public GameObject Identifier3;
    public GameObject Identifier4;
    public GameObject Identifier5;
    //If im gonna put it in each object I need to know which spawn point is the object spawning at.
    //I can know that by the name of the object because the name of the object says the spawn point at which it is spawning.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Identifier1 = GameObject.Find("S1I");
        Identifier2 = GameObject.Find("S2I");
        Identifier3 = GameObject.Find("S3I");
        Identifier4 = GameObject.Find("S4I");
        Identifier5 = GameObject.Find("S5I");
    }

    void OnMouseDown()
    {
        if(this.gameObject.name =="S1")//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
            if (this.gameObject.tag == Identifier1.gameObject.tag && Identifier1.gameObject.name == "S1I")
            {
                //Now we know is the correct tag meaning same color and we know is the correct identifier at spawn point 1;
                //If this checks, player gets points, we destroy this object, and we destroy spawn point 1.
            }
            else if(this.gameObject.tag != Identifier1.gameObject.tag && Identifier1.gameObject.name == "S1I")
            {
                //This means the tag is not the same meaning the color is not the same, but it is the correct spawn point object to destroy. 
                //If this checks then player loses a life, we destroy this object, and we destroy spawn point1.

                //**NOTE TO SELF** IF NONE OF THESE CHECK THAT MEANS THAT EITHER THIS OBJECT IS NOT AT SPAWN POINT 1.
            }
            
        }
        if (this.gameObject.name == "S2" && this.gameObject.tag == Identifier2.gameObject.tag)//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
        }
        if (this.gameObject.name == "S3" && this.gameObject.tag == Identifier3.gameObject.tag)//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
        }
        if (this.gameObject.name == "S4" && this.gameObject.tag == Identifier4.gameObject.tag)//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
        }
        if (this.gameObject.name == "S5" && this.gameObject.tag == Identifier5.gameObject.tag)//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
        }
        else
        {
            //Wrong color destroy the object, decrease the players lives, and destroy the Identifier. TOMORROW 
        }

        //Make separate if statements where you check the name of the Identifier and the tag. that way if only the tag is wrong then we know which identifier to destroy

    }
}
