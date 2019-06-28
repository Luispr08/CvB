using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public static float speed;
    public Rigidbody cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        cubes.velocity = new Vector3(0, speed, 0);
    }
}
