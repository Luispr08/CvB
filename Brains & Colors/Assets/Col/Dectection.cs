﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dectection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col) //If cubes touch identifier cubes and identifier destroy// Here I have to add the reduction of lives if this happens.
    {
        //Debug.Log("collision name = " + col.gameObject.name); //I have to specify with which object should they collide in order to disspear
        if (col.gameObject.name == "BlueIdentifier(Clone)" || col.gameObject.name == "YellowIdentifier(Clone)" || col.gameObject.name == "RedIdentifier(Clone)" || col.gameObject.name == "PinkIdentifier(Clone)" ||
            col.gameObject.name == "OrangeIdentifier(Clone)" ||  col.gameObject.name == "GreenIdentifier(Clone)" || col.gameObject.name == "PurpleIdentifier(Clone)")
        {
            Tap.CubeNumberTracker = 0; //The player missed the cube before it touched the identifier therefore we reset the number of consecutive cubes the player has clicked
            MultiplierScript.multi = 0;//The player missed the cube before it tocuhed the identifier thefore we take away the multiplier the player was building (Reset to zero).
            Destroy(col.gameObject); //This is the name of the identifier therefore is destroyed. "col" that is.
            Destroy(this.gameObject);//This destroys all the objects that have this script.
            if (Levels.Disabler == 1)
            {
                Levels.setter = 1;
            }
        }
        
    }

}
