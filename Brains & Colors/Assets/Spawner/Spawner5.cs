using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner5 : MonoBehaviour
{
    
    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject PinkCube;
    public GameObject OrangeCube;
    public GameObject GreenCube;
    public GameObject PurpleCube;
    private float time = 0.0f;
    private static float WindowTime = 0.0f;
    public static int S5;
    void Start()
    {
        YellowCube = Resources.Load<GameObject>("Objects/Cubes/YellowCube");
        RedCube = Resources.Load<GameObject>("Objects/Cubes/RedCube");
        BlueCube = Resources.Load<GameObject>("Objects/Cubes/BlueCube");
        PinkCube = Resources.Load<GameObject>("Objects/Cubes/PinkCube");
        OrangeCube = Resources.Load<GameObject>("Objects/Cubes/OrangeCube");
        GreenCube = Resources.Load<GameObject>("Objects/Cubes/GreenCube");
        PurpleCube = Resources.Load<GameObject>("Objects/Cubes/PurpleCube");
    }

    // Update is called once per frame
    //LV 1:  Cubes spawn every second.
    void Update()
    {

        time += Time.deltaTime;
        int RanNum = rangen.n5; //Generates a random number between 1 and 7 to choose for the number
        //NOTES*****
        /*
         * When the player starts playing First Spawn is false meaning that the cubes that are about to spawn are the first ones and that way we allow them to spawn.
         * Once FirstSpawn turns true it means that the cubes have spawned for the first time. Now the RespawnFlag will be turn to true once any cube no matter if wrong or right is tapped on
         * this way I can control weather the 3rd wave of cubes should spawn.
         * This is specially for when cubes are slow and they dont get destroyed by the player before they variable time reaches the next time interval where the cubes are spawn. This way the interval has been met and the cubes will spawn as soon 
         * the cubes are destroyed.
         * THE CUBES SHOULD ALWAYS HAVE A HALF A SECOND WINDOW BEFORE THEY SPAWN SO THEY  PLAYER IS CAPABLE OF BEING READY FOR THE NEXT WAVE. 
        */
        if (time >= 2f && (Tap.FirstSpawn ==false || Tap.RespawnFlag ==true)) //Hihger this number for less frequency; lower for more frequency // FirstSpawn means the player started the game. RespawnFlag means the player has been playing
        {
            //WindowTime += Time.deltaTime; //As soon as the conditions above are met we want to wait .5 seconds for the next wave of cubes to appear. This allows the player to be ready. in the future we can reduce this depending on the level.
            //if(WindowTime >= 0.5f) //HALF A SECOND WINDOW SHOULD BE HERE
            

            if (RanNum == 1)
            {
                Instantiate(YellowCube, transform.position, transform.rotation);
               // print("Yellow Cube was spawned");
            }
            else if (RanNum == 2)
            {
                Instantiate(RedCube, transform.position, transform.rotation);
               // print("Red Cube was spawned");
            }
            else if (RanNum == 3)
            {
                Instantiate(BlueCube, transform.position, transform.rotation);
               // print("Blue Cube was spawned");
            }
            else if (RanNum == 4)
            {
                Instantiate(PinkCube, transform.position, transform.rotation);
               // print("Pink Cube was spawned");
            }
            else if (RanNum == 5)
            {
                Instantiate(OrangeCube, transform.position, transform.rotation);
              //  print("Orange Cube was spawned");
            }
            else if (RanNum == 6)
            {
                Instantiate(GreenCube, transform.position, transform.rotation);
                //print("Green Cube was spawned");
            }
            else if (RanNum == 7)
            {
                Instantiate(PurpleCube, transform.position, transform.rotation);
               // print("Purple was spawned");
            }
            time = time % 1f; //Same for this number.

            Tap.FirstSpawn = true;

            //WindowTime = WindowTime % 1f;
        }


        //Create a function that will spawn the object depending on the score of the player.
        //SCORE OR LEVEL PLAYER FUNCTION.
        //Random function "Random.Ragen(1,5)" the number 1 or 5 is the range of numbers that will be chosen randomly.
    }
}
