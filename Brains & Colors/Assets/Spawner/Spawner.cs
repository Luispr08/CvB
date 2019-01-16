using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject PinkCube;
    public GameObject OrangeCube;
    public GameObject GreenCube;
    private float time = 0.0f;
    
    void Start ()
    {
        YellowCube = Resources.Load<GameObject>("Objects/Cubes/YellowCube");
    }
	
	// Update is called once per frame
    //LV 1:  Cubes spawn every second.
	void Update ()
    {
        
        time += Time.deltaTime;
        if (time >= 2f) //Hihger this number for less frequency; lower for more frequency
        {
            
            Instantiate(YellowCube, transform.position, transform.rotation);
            print("Object was spawned");
            time = time % 1f; //Same for this number.
        }
        

        //Create a function that will spawn the object depending on the score of the player.
        //SCORE OR LEVEL PLAYER FUNCTION.
        //Random function "Random.Ragen(1,5)" the number 1 or 5 is the range of numbers that will be chosen randomly.
    }
}
