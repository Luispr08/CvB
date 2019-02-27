using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesScript : MonoBehaviour
{
    public static int lives;
    TextMesh Livestext;
    // Start is called before the first frame update
    void Start()
    {
        Livestext = gameObject.GetComponent("TextMesh") as TextMesh;
        lives = 3; //restarts lives after scene is loaded.
    }

    // Update is called once per frame
    void Update()
    {
        Livestext.text = "Lives: " + lives.ToString();

    }
}
