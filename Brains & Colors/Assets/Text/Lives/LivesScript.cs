using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesScript : MonoBehaviour
{
    public static int lives = 3;
    TextMesh Livestext;
    // Start is called before the first frame update
    void Start()
    {
        Livestext = gameObject.GetComponent("TextMesh") as TextMesh;
    }

    // Update is called once per frame
    void Update()
    {
        Livestext.text = "Lives: " + lives.ToString();

    }
}
