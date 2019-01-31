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

    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject PinkCube;
    public GameObject OrangeCube;
    public GameObject GreenCube;
    public GameObject PurpleCube;

    public GameObject LivesUpdater;
    public GameObject CurrentRec;
    
    public List<GameObject> allObjectsInScene;
    // Start is called before the first frame update
    void Start()
    {
        YellowRectangle = GameObject.Find("YellowIdentifier(Clone)");
        RedRectangle = GameObject.Find("RedIdentifier(Clone)");
        BlueRectangle = GameObject.Find("BlueIdentifier(Clone)");
        PinkRectangle = GameObject.Find("PinkIdentifier(Clone)");
        OrangeRectangle = GameObject.Find("OrangeIdentifier(Clone)");
        GreenRectangle = GameObject.Find("GreenIdentifier(Clone)");
        PurpleRectangle = GameObject.Find("PurpleIdentifier(Clone)");

        YellowCube = GameObject.Find("YellowCube(Clone)");
        RedCube = GameObject.Find("RedCube(Clone)");
        BlueCube = GameObject.Find("BlueCube(Clone)");
        PinkCube = GameObject.Find("PinkCube(Clone)");
        OrangeCube = GameObject.Find("OrangeCube(Clone)");
        GreenCube = GameObject.Find("GreenCube(Clone)");
        PurpleCube = GameObject.Find("PurpleCube(Clone)");

        LivesUpdater = GameObject.Find("LivesUpdater(Clone)"); //Rule to follow: All the objects in the scene should be destroyed in order to be able to destroy this object.
    }

    // Update is called once per frame
    void Update()
    {
        allObjectsInScene = new List<GameObject> {LivesUpdater,YellowRectangle,YellowCube, RedRectangle, RedCube, BlueCube, BlueRectangle, PinkCube, PinkRectangle, OrangeCube, OrangeRectangle, GreenCube, GreenRectangle, PurpleCube,  PurpleRectangle }; //List of all the objects in the scene
        //We check if any of these rectangle are currently in the scene if one of them is we set it to Current Rec which will be the variable to check if the clicked object is of the same tag.
        if (YellowRectangle != null)
        {
            CurrentRec = YellowRectangle;
        }
        if (RedRectangle != null)
        {
            CurrentRec = RedRectangle;
        }
        if (BlueRectangle != null)
        {
            CurrentRec = BlueRectangle;
        }
        if (PinkRectangle != null)
        {
            CurrentRec = PinkRectangle;
        }
        if (OrangeRectangle != null)
        {
            CurrentRec = OrangeRectangle;
        }
        if (GreenRectangle != null)
        {
            CurrentRec = GreenRectangle;
        }
        if (PurpleRectangle != null)
        {
            CurrentRec = PurpleRectangle;
        }
       
        //Debug.Log("Tapper working");

    }
    private void OnMouseDown()
    {
        //Debug.Log("Cube tag is: "+ this.gameObject.tag);
        //Debug.Log("Rec tag is: "+ CurrentRec.gameObject.tag);

        if (this.gameObject.tag == CurrentRec.gameObject.tag && GameObject.FindGameObjectsWithTag(this.gameObject.tag).Length ==2) //If lenght is 2 or less means that there's only one cube of the same color as the rectangle and since we matched the color we can destroy all the cubes for the next wave to come in. 
         {
            //CORRECT COLOR!: destroy all the objects, add multiplier and increase score. 
            //Destroy all objects in the scene in order to obtain the next wave of cubes.
            ScoreScript.score += 100;
            foreach (GameObject allObjectsInScene in allObjectsInScene)
            {
                Destroy(allObjectsInScene);
            }
        }
      else if (this.gameObject.tag == CurrentRec.gameObject.tag && GameObject.FindGameObjectsWithTag(gameObject.tag).Length > 2) //If this conditioned is met that means there is more than one cube of the same color as the identifier therefore I need to delete this one cube and update stats.
        {
            //CORRECT COLOR!: Destroy only this object, add multiplier, and update score.
            ScoreScript.score += 100;
            Destroy(this.gameObject);
        }
        else if (GameObject.FindGameObjectWithTag(gameObject.tag) != GameObject.FindGameObjectWithTag(CurrentRec.gameObject.tag)) //
        {
            //WRONG COLOR!: destroy this object, decrease multiplier, and update lives.
            LivesScript.lives -= 1;
            Destroy(this.gameObject);
        }

    }

    
}
