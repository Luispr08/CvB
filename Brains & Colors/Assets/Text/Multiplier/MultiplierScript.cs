using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int multi = 0;
    TextMesh MultiText;
    void Start()
    {
        MultiText = gameObject.GetComponent("TextMesh") as TextMesh;
    }

    // Update is called once per frame
    void Update()
    {
        MultiText.text = "X " + multi.ToString();
    }
}
