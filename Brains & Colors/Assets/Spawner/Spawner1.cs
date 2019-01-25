using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public static Spawner1 SP1;
    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject PinkCube;
    public GameObject OrangeCube;
    public GameObject GreenCube;
    public GameObject PurpleCube;
    private float time = 0.0f;
    public static int S1;

    void Start()
    {
        YellowCube = Resources.Load<GameObject>("Objects/Cubes/YellowCube");
        RedCube = Resources.Load<GameObject>("Objects/Cubes/RedCube");
        BlueCube = Resources.Load<GameObject>("Objects/Cubes/BlueCube");
        PinkCube = Resources.Load<GameObject>("Objects/Cubes/PinkCube");
        OrangeCube = Resources.Load<GameObject>("Objects/Cubes/OrangeCube");
        GreenCube = Resources.Load<GameObject>("Objects/Cubes/GreenCube");
        PurpleCube = Resources.Load<GameObject>("Objects/Cubes/PurpleCube");
        //int levelup;//This will be used for when the user levels up and another color is added.
    }

    // Update is called once per frame
    //LV 1:  Cubes spawn every second.
   void Update()
    {
        
        
        time += Time.deltaTime;
        int RanNum = rangen.n1; //Generates a random number between 1 and 7 to choose for the number
        if (time >= 2f) //Hihger this number for less frequency; lower for more frequency
        {
         //   S1 = RanNum; //Global variable used to choose a random spawned color.

            if (RanNum == 1)
            {
                Instantiate(YellowCube, transform.position, transform.rotation);
                print("Yellow Cube was spawned");
            }
            else if (RanNum == 2)
            {
                Instantiate(RedCube, transform.position, transform.rotation);
                print("Red Cube was spawned");
            }
            else if (RanNum == 3)
            {
                Instantiate(BlueCube, transform.position, transform.rotation);
                print("Blue Cube was spawned");
            }
            else if (RanNum == 4)
            {
                Instantiate(PinkCube, transform.position, transform.rotation);
                print("Pink Cube was spawned");
            }
            else if (RanNum == 5)
            {
                Instantiate(OrangeCube, transform.position, transform.rotation);
                print("Orange Cube was spawned");
            }
            else if (RanNum == 6)
            {
                Instantiate(GreenCube, transform.position, transform.rotation);
                print("Green Cube was spawned");
            }
            else if(RanNum == 7)
            {
                Instantiate(PurpleCube, transform.position, transform.rotation);
                print("Purple was spawned");
            }
            
            time = time % 1f; //Same for this number.
        }

      

        //Create a function that will spawn the object depending on the score of the player.
        //SCORE OR LEVEL PLAYER FUNCTION.
        //Random function "Random.Ragen(1,5)" the number 1 or 5 is the range of numbers that will be chosen randomly.
    }
}