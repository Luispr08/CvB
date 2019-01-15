using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Object ObjecttoSpawn;
    void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("a"))
        {
            Instantiate(ObjecttoSpawn, transform.position, transform.rotation);
            print("Object was spawned");
        }
    }
}
