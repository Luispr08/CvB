using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesDecreaserUpdater : MonoBehaviour
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
        //Debug.Log("collision name = " + col.gameObject.name); //I have to specify whith which object should they collide in order to disspear
        if (col.gameObject.name == "BlueIdentifier(Clone)" || col.gameObject.name == "YellowIdentifier(Clone)" || col.gameObject.name == "RedIdentifier(Clone)" || col.gameObject.name == "PinkIdentifier(Clone)" ||
            col.gameObject.name == "OrangeIdentifier(Clone)" || col.gameObject.name == "GreenIdentifier(Clone)" || col.gameObject.name == "PurpleIdentifier(Clone)")
        {
            LivesScript.lives -= 1;
            Destroy(this.gameObject); 
        }

    }
}
