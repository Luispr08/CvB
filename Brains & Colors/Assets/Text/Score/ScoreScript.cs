using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
   public static int score = 0;
    TextMesh Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Scoretext = gameObject.GetComponent("TextMesh") as TextMesh;
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Score: " + score.ToString();
        
    }
}
