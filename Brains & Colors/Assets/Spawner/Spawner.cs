using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject YellowRectangle;
    public GameObject RedRectangle;
    public GameObject BlueRectangle;
    public GameObject PinkRectangle;
    public GameObject OrangeRectangle;
    public GameObject GreenRectangle;
    public GameObject PurpleRectangle;
    private float time = 0.0f;
    public bool flag = false;

    public static bool sp = false;


    void Start ()
    {
        YellowRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/YellowIdentifier");
        RedRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/RedIdentifier");
        BlueRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/BlueIdentifier");
        PinkRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/PinkIdentifier");
        OrangeRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/OrangeIdentifier");
        GreenRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/GreenIdentifier");
        PurpleRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/PurpleIdentifier");
    }
	
	// Update is called once per frame
    
	void Update ()
    {
        
        if (flag == false)
        {
            rangen.rangenerator();
            flag = true;
           
        }
        
            time += Time.deltaTime;
            int RanNum = rangen.Ident;
            if (time >= 2f) //This should be only every time the cube with its corresponding color is destroyed.
            {

                //WindowTime += Time.deltaTime; //As soon as the conditions above are met we want to wait .5 seconds for the next wave of cubes to appear. This allows the player to be ready. in the future we can reduce this depending on the level.
                //if(WindowTime >= 0.5f) //HALF A SECOND WINDOW SHOULD BE HERE

                if (RanNum == 1)
                {
                    Instantiate(YellowRectangle, transform.position, transform.rotation);
                    // print("Yellow Rec was spawned");
                    
                }
                else if (RanNum == 2)
                {
                    Instantiate(RedRectangle, transform.position, transform.rotation);
                    //  print("Red Rec was spawned");
                    

                }
                else if (RanNum == 3)
                {
                    Instantiate(BlueRectangle, transform.position, transform.rotation);
                    // print("Blue Rec was spawned");
                    

                }
                else if (RanNum == 4)
                {
                    Instantiate(PinkRectangle, transform.position, transform.rotation);
                    //print("Pink Rec was spawned");
                

                }
                else if (RanNum == 5)
                {
                    Instantiate(OrangeRectangle, transform.position, transform.rotation);
                    // print("Orange Rec was spawned");
                  
                }
                else if (RanNum == 6)
                {
                    Instantiate(GreenRectangle, transform.position, transform.rotation);
                    //print("Green Rec was spawned");
                    
                }
                else if (RanNum == 7)
                {
                    Instantiate(PurpleRectangle, transform.position, transform.rotation);
                    //print("Purple Rec was spawned");
                    
                }
                Debug.Log("An identifier has been created");
                time = time % 1f; //Same for this number.
                flag = false;

                

            }
        
        


        //Create a function that will spawn the object depending on the score of the player.
        //SCORE OR LEVEL PLAYER FUNCTION.
        //Random function "Random.Ragen(1,5)" the number 1 or 5 is the range of numbers that will be chosen randomly.
    }
}
