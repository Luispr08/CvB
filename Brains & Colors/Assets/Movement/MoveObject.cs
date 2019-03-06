using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public static float speed = -2;
    private Rigidbody cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = GetComponent<Rigidbody>();
        //speed = -2;
        //cubes.velocity = new Vector3(0, speed, 0); //The velocity will increase with respect to time and score of the player.
    }

    public void Update()
    {
        cubes.velocity = new Vector3(0, speed, 0);
    }
}
