using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Object was tapped");
        //Detect which object got tapped on
        //Check if the tag matches the identifiers tag.
        //Do if statements to decide which function to call to either destroy all the objects or just that one object.
       //public var Tag_checker: GameObject;
        GameObject.FindGameObjectWithTag(gameObject.tag); //We get the tag of this object
        
    }

    void Des_all() //We tapped the correct object destroy all the objects
    {

    }
    void Des_one() //We tapped the wrong object destroy only the tapped object.
    {

    }
}
