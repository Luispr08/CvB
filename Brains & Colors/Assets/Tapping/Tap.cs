using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    public GameObject YellowRectangle;
    public GameObject RedRectangle;
    public GameObject BlueRectangle;
    public GameObject PinkRectangle;
    public GameObject OrangeRectangle;
    public GameObject GreenRectangle;
    public GameObject PurpleRectangle;
    string current;

    public GameObject CurrentRec;
    public Deleter obj;
    // Start is called before the first frame update
    void Start()
    {
        YellowRectangle = GameObject.Find("YellowIdentifier");
        RedRectangle = GameObject.Find("RedIdentifier");
        BlueRectangle = GameObject.Find("BlueIdentifier");
        PinkRectangle = GameObject.Find("PinkIdentifier");
        OrangeRectangle = GameObject.Find("OrangeIdentifier");
        GreenRectangle = GameObject.Find("GreenIdentifier");
        PurpleRectangle = GameObject.Find("PurpleIdentifier");

    }

    // Update is called once per frame
    void Update()
    {
        //We check if any of these rectangle are currently in the scene if one of them is we set it to Current Rec which will be the variable to check if the clicked object is of the same tag.
        if (YellowRectangle)
        {
            CurrentRec = YellowRectangle;
        }
        else if (RedRectangle)
        {
            CurrentRec = RedRectangle;
        }
        else if (BlueRectangle)
        {
            CurrentRec = BlueRectangle;
        }
        else if (PinkRectangle)
        {
            CurrentRec = PinkRectangle;
        }
        else if (OrangeRectangle)
        {
            CurrentRec = OrangeRectangle;
        }
        else if (GreenRectangle)
        {
            CurrentRec = GreenRectangle;
        }
        else if (PurpleRectangle)
        {
            CurrentRec = PurpleRectangle;
        }
    }
    private void OnMouseDown()
    {
        Debug.Log("Object was tapped");
        //Detect which object got tapped on
        //Check if the tag matches the identifiers tag.
        //Do if statements to decide which function to call to either destroy all the objects or just that one object.
       //public var Tag_checker: GameObject;
        //We get the tag of this objec

        if (GameObject.FindGameObjectWithTag(gameObject.tag) == GameObject.FindGameObjectWithTag(CurrentRec.gameObject.tag) && GameObject.FindGameObjectsWithTag(gameObject.tag).Length <=2)
        {
            //We check if the game object that we clicked matches the identifier that spawned. If it does we check if there is only 2 objects with the same tag if yes then we destroy all the objects, add multiplier and increase score. 
            //Destroy all objects in the scene in order to obtain the next wave of objects.
            ///DeleteAll();
            Destroy(this.gameObject);
            Destroy(CurrentRec.gameObject);
        }
        /*else if (GameObject.FindGameObjectWithTag(gameObject.tag) == GameObject.FindGameObjectWithTag(CurrentRec.gameObject.tag) && GameObject.FindGameObjectsWithTag(gameObject.tag).Length > 2) //If the object is only one that means the player clicked the wrong cube therefore I only delete that one cube and decrease the multiplier and decrease a life.
        {
            //Destroy only this object, add multiplier, and update score.
            Destroy(this.gameObject);
        }
        else if (GameObject.FindGameObjectWithTag(gameObject.tag) != GameObject.FindGameObjectWithTag(CurrentRec.gameObject.tag)) //
        {
            //we destroy this object, decrease multiplier, and update lives.
            Destroy(this.gameObject);
        }*/
        
    }

    //void DeleteAll() //We tapped the correct object destroy all the objects
    //{
      //  obj.Del();
    //}
    
}
