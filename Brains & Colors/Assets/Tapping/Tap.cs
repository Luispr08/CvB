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

    public static GameObject LivesUpdater;
    public GameObject CurrentRec;

    public GameObject ShowMulti;
    public TextMesh Multipliermesh;

    public static bool RespawnFlag = true;
    public static bool FirstSpawn = true;

    public static int CubeNumberTracker = 0; //This will track how many consecutive cubes has the player clicked.
    public List<GameObject> allObjectsInScene;

    


    // Start is called before the first frame update

    void Start()
    {
        //Every static variable has to bee initialized in start in order for it to restart when the scene has been loaded more than once.
        RespawnFlag = true;
        FirstSpawn = true;

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
        allObjectsInScene = new List<GameObject> { LivesUpdater, YellowRectangle, YellowCube, RedRectangle, RedCube, BlueCube, BlueRectangle, PinkCube, PinkRectangle, OrangeCube, OrangeRectangle, GreenCube, GreenRectangle, PurpleCube, PurpleRectangle }; //List of all the objects in the scene


        
    }

    // Update is called once per frame
    void Update()
    {
        //allObjectsTags = new List<string> {LivesUpdater.tag,YellowRectangle.tag, YellowCube.tag, RedRectangle.tag, RedCube.tag, BlueCube.tag, BlueRectangle.tag, PinkCube.tag, PinkRectangle.tag, OrangeCube.tag, OrangeRectangle.tag, GreenCube.tag, GreenRectangle.tag, PurpleCube.tag, PurpleRectangle.tag };
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
    public void OnMouseDown()
    {
        //Debug.Log("Cube tag is: "+ this.gameObject.tag);
        // Debug.Log("Rec tag is: "+ CurrentRec.gameObject.tag);

        var OBJ = this.gameObject;

        if (OBJ.tag == CurrentRec.gameObject.tag && GameObject.FindGameObjectsWithTag(OBJ.tag).Length == 2) //If lenght is 2 or less means that there's only one cube of the same color as the rectangle and since we matched the color we can destroy all the cubes for the next wave to come in. 
        {
           
            //CORRECT COLOR!: destroy all the objects, add multiplier and increase score. 
            //Destroy all objects in the scene in order to obtain the next wave of cubes.
            //---------------------------------------------------------------------------
            //Multiplier Code
            CubeNumberTracker += 1; //Adds the number of cubes the player has clicked.
            
            MultiplierUpdater(); //Updates the multiplier based on the number of consecutive cubes clicked.
                                 //---------------------------------------------------------------------------
            
            if (MultiplierScript.multi >= 1) //This shows the multiplier text coming out of the cube when the player hits a cube and a multiplier.
            { 
                var MultiNumber = Instantiate(ShowMulti, transform.position, transform.rotation);
                MultiNumber.GetComponent<TextMesh>().text = "100X" + MultiplierScript.multi.ToString() + "!";
            }

              foreach (GameObject ObjectInScene in allObjectsInScene)
            {
                Destro();
                Destroy(ObjectInScene);
            }
            
            Destroy(this.gameObject);
            
            if (Levels.Disabler == 0)
            {
                UltimateCubeSpawner.SpawnCTRL = true; //Tells the UltimateCubeSpawner that all the cubes un the scene have been destroyed so spawning new cubes and a new identifier is safe.
            }
            if(Levels.Disabler==1)
            {
                Levels.setter = 1; 
            }
        }
      else if (OBJ.tag == CurrentRec.gameObject.tag && GameObject.FindGameObjectsWithTag(OBJ.tag).Length > 2) //If this conditioned is met that means there is more than one cube of the same color as the identifier therefore I need to delete this one cube and update stats.
        {
            //CORRECT COLOR!: Destroy only this object, add multiplier, and update score.
            
            CubeNumberTracker += 1;
            if (MultiplierScript.multi >= 1) //This shows the multiplier text coming out of the cube when the player hits a cube and a multiplier.
            {
                var MultiNumber = Instantiate(ShowMulti, transform.position, transform.rotation);
                MultiNumber.GetComponent<TextMesh>().text = "100X" + MultiplierScript.multi.ToString() + "!";
            }
            MultiplierUpdater();
            
            Destroy(OBJ);
            
        }
        else if (GameObject.FindGameObjectWithTag(OBJ.tag) != GameObject.FindGameObjectWithTag(CurrentRec.gameObject.tag)) //
        {
            //WRONG COLOR!: destroy this object, decrease multiplier, and update lives.
            
            LivesScript.lives -= 1; //If the condition above is met then the player clicked the wrong cube therefore we decreasea life.

            CubeNumberTracker = 0; //If the player clickes the wrong cube then we reset the number of consecutive cubes clicked to ZERO. 

            MultiplierScript.multi = 0; //If the player clickes the wrong number we reset the multiplier to zero.
            
            Destroy(OBJ);
            
        }

    }

    
    public void MultiplierUpdater()
    {
        if (CubeNumberTracker < 5)
        {
            ScoreScript.score += 100;
        }
        else if (CubeNumberTracker >= 5 && CubeNumberTracker < 10) //First multiplier applies after clicking first 5 cubes and for the next 4 cubes.
        {
            ScoreScript.score += 200;

            MultiplierScript.multi = 2;//The user has clicked 5 consecutive corerct colored cubes therefore we increase the multiplier by 2. 
        }
        else if (CubeNumberTracker >= 10 && CubeNumberTracker < 15)//Second multiplier after 10
        {
            ScoreScript.score += 300;

            MultiplierScript.multi = 3;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 3.
        }
        else if (CubeNumberTracker >= 15 && CubeNumberTracker < 20)//Third at 15
        {
            ScoreScript.score += 400;

            MultiplierScript.multi = 4;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 4.
        }
        else if (CubeNumberTracker >= 20 && CubeNumberTracker < 25)//Fourth at 20
        {
            ScoreScript.score += 500;

            MultiplierScript.multi = 5;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 5.
        }
        else if (CubeNumberTracker >= 25 && CubeNumberTracker < 30)//Fifth at 25
        {
            ScoreScript.score += 600;

            MultiplierScript.multi = 6;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 6.
        }
        else if (CubeNumberTracker >= 30 && CubeNumberTracker < 35)//Sixth at 30
        {
            ScoreScript.score += 700;

            MultiplierScript.multi = 7;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 7.
        }
        else if (CubeNumberTracker >= 35 && CubeNumberTracker < 40)//Seventh at 35
        {
            ScoreScript.score += 800;

            MultiplierScript.multi = 8;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 8.
        }
        else if (CubeNumberTracker >= 40 && CubeNumberTracker < 45)//Eight at 40
        {
            ScoreScript.score += 900;

            MultiplierScript.multi = 9;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 9.
        }
        else if (CubeNumberTracker >= 45)//nineth at 45
        {
            ScoreScript.score += 1000;
            MultiplierScript.multi = 10;//The user has clicked another 5 consecutive corerct colored cubes therefore we increase the multiplier by 10.
        }
        
    }

    public static void Destro() //This works temporarily it makes sures it destroys every cube and rectangle in the scene
    {
        Destroy(LivesUpdater);
        var tags = GameObject.FindGameObjectsWithTag("Blue");
        foreach (var clone in tags)
        {
            Destroy(clone);
        }
        var tags1 = GameObject.FindGameObjectsWithTag("Yellow");
        foreach (var clone in tags1)
        {
            Destroy(clone);
        }
        var tags2 = GameObject.FindGameObjectsWithTag("Red");
        foreach (var clone in tags2)
        {
            Destroy(clone);
        }
        var tags3 = GameObject.FindGameObjectsWithTag("Green");
        foreach (var clone in tags3)
        {
            Destroy(clone);
        }
        var tags4 = GameObject.FindGameObjectsWithTag("Orange");
        foreach (var clone in tags4)
        {
            Destroy(clone);
        }
        var tags5 = GameObject.FindGameObjectsWithTag("Purple");
        foreach (var clone in tags5)
        {
            Destroy(clone);
        }
        var tags6 = GameObject.FindGameObjectsWithTag("Pink");
        foreach (var clone in tags6)
        {
            Destroy(clone);
        }

    }

    


}
