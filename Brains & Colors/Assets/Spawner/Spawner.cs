using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform Spawnpoint;
    public GameObject Cube;
    public KeyCode Ctrl;
    void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {   if (Input.GetKeyDown(Ctrl))
        {
            Instantiate(Cube, Spawnpoint.position, Spawnpoint.rotation);
            
        }

    }
}
