﻿using System.Collections;
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

   public void OnMouseDown()
    {
        Debug.Log("You clicked S1");
        if (this.gameObject.name =="S1")//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
            if (this.gameObject.tag == Identifier1.gameObject.tag && Identifier1.gameObject.name == "S1I")
            {
                //Now we know is the correct tag meaning same color and we know is the correct identifier at spawn point 1;
                //If this checks, player gets points, we destroy this object, and we destroy spawn point 1.
                Debug.Log("Correct Color destroy S1 and spawn1");
            }
            else if(this.gameObject.tag != Identifier1.gameObject.tag && Identifier1.gameObject.name == "S1I")
            {
                //This means the tag is not the same meaning the color is not the same, but it is the correct spawn point object to destroy. 
                //If this checks then player loses a life, we destroy this object, and we destroy spawn point1.

                //**NOTE TO SELF** IF NONE OF THESE CHECK THAT MEANS THAT EITHER THIS OBJECT IS NOT AT SPAWN POINT 1.
                Debug.Log("Wrong Color destroy S1 and spawn1");
            }
            
        }
        else if (this.gameObject.name == "S2" )//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
            //We clicked the right color at spawn 1.
            if (this.gameObject.tag == Identifier1.gameObject.tag && Identifier1.gameObject.name == "S2I")
            {
                //Now we know is the correct tag meaning same color and we know is the correct identifier at spawn point 1;
                //If this checks, player gets points, we destroy this object, and we destroy spawn point 1.
                Debug.Log("Correct Color destroy S3 and spawn3");
            }
            else if (this.gameObject.tag != Identifier1.gameObject.tag && Identifier1.gameObject.name == "S2I")
            {
                //This means the tag is not the same meaning the color is not the same, but it is the correct spawn point object to destroy. 
                //If this checks then player loses a life, we destroy this object, and we destroy spawn point1.

                //**NOTE TO SELF** IF NONE OF THESE CHECK THAT MEANS THAT EITHER THIS OBJECT IS NOT AT SPAWN POINT 1.
                Debug.Log("Wrong Color destroy S2 and spawn2");
            }
        }
        else if (this.gameObject.name == "S3" )//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
            //We clicked the right color at spawn 1.
            if (this.gameObject.tag == Identifier1.gameObject.tag && Identifier1.gameObject.name == "S3I")
            {
                //Now we know is the correct tag meaning same color and we know is the correct identifier at spawn point 1;
                //If this checks, player gets points, we destroy this object, and we destroy spawn point 1.
                Debug.Log("Correct Color destroy S3 and spawn3");
            }
            else if (this.gameObject.tag != Identifier1.gameObject.tag && Identifier1.gameObject.name == "S3I")
            {
                //This means the tag is not the same meaning the color is not the same, but it is the correct spawn point object to destroy. 
                //If this checks then player loses a life, we destroy this object, and we destroy spawn point1.

                //**NOTE TO SELF** IF NONE OF THESE CHECK THAT MEANS THAT EITHER THIS OBJECT IS NOT AT SPAWN POINT 1.
                Debug.Log("Wrong Color destroy S3 and spawn3");
            }
        }
        else if (this.gameObject.name == "S4" )//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
            //We clicked the right color at spawn 1.
            if (this.gameObject.tag == Identifier1.gameObject.tag && Identifier1.gameObject.name == "S4I")
            {
                //Now we know is the correct tag meaning same color and we know is the correct identifier at spawn point 1;
                //If this checks, player gets points, we destroy this object, and we destroy spawn point 1.
                Debug.Log("Correct Color destroy S4 and spawn4");
            }
            else if (this.gameObject.tag != Identifier1.gameObject.tag && Identifier1.gameObject.name == "S4I")
            {
                //This means the tag is not the same meaning the color is not the same, but it is the correct spawn point object to destroy. 
                //If this checks then player loses a life, we destroy this object, and we destroy spawn point1.

                //**NOTE TO SELF** IF NONE OF THESE CHECK THAT MEANS THAT EITHER THIS OBJECT IS NOT AT SPAWN POINT 1.
                Debug.Log("Wrong Color destroy S4 and spawn4");
            }
        }
        else if (this.gameObject.name == "S5" )//Means it spawned at spawnpoint 1
        {
            //We clicked the right color at spawn 1.
            //We clicked the right color at spawn 1.
            if (this.gameObject.tag == Identifier1.gameObject.tag && Identifier1.gameObject.name == "S5I")
            {
                //Now we know is the correct tag meaning same color and we know is the correct identifier at spawn point 1;
                //If this checks, player gets points, we destroy this object, and we destroy spawn point 1.
                Debug.Log("Correct Color destroy S5 and spawn5");
            }
            else if (this.gameObject.tag != Identifier1.gameObject.tag && Identifier1.gameObject.name == "S5I")
            {
                //This means the tag is not the same meaning the color is not the same, but it is the correct spawn point object to destroy. 
                //If this checks then player loses a life, we destroy this object, and we destroy spawn point1.

                //**NOTE TO SELF** IF NONE OF THESE CHECK THAT MEANS THAT EITHER THIS OBJECT IS NOT AT SPAWN POINT 1.
                Debug.Log("Wrong Color destroy S5 and spawn5");
            }
        }
       

        //Make separate if statements where you check the name of the Identifier and the tag. that way if only the tag is wrong then we know which identifier to destroy

    }
}
