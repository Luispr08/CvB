using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    float speed = 5;
    private Rigidbody cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = GetComponent<Rigidbody>();

        cubes.velocity = new Vector3(0, -10, 0); //The velocity will increase with respect to time and score of the player.
    }
}
