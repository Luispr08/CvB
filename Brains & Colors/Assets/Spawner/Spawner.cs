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
    public int C1, C2, C3, C4, C5;
    


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
        //This code will choose a color from the cubes spawned in order to slways spawn a color identifier that at least matches one of the spawned cubes.
        //C1 = Spawner1.S1;
        //C2 = Spawner2.S2;
        //C3 = Spawner3.S3;
        //C4 = Spawner4.S4;
        //C5 = Spawner5.S5;

        //System.Random r = new System.Random();
        //var values = new[] { C1, C2, C3, C4, C5 };
        //int RanNum = values[r.Next(values.Length)];

        if (flag == false)
        {
            rangen.rangenerator();
            flag = true;
        }
        
        time += Time.deltaTime;
        int RanNum = rangen.Ident;
        if (time >= 2f) //This should be only every time the cube with its corresponding color is destroyed.
        {
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
            time = time % 1f; //Same for this number.
            flag = false;
        }
        


        //Create a function that will spawn the object depending on the score of the player.
        //SCORE OR LEVEL PLAYER FUNCTION.
        //Random function "Random.Ragen(1,5)" the number 1 or 5 is the range of numbers that will be chosen randomly.
    }
}
