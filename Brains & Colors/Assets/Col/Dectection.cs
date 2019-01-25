using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dectection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collision name = " + col.gameObject.name); //I have to specify whith which object should they collide in order to disspear
        if (col.gameObject.name == "BlueIdentifier(Clone)" || col.gameObject.name == "YellowIdentifier(Clone)" || col.gameObject.name == "RedIdentifier(Clone)" || col.gameObject.name == "PinkIdentifier(Clone)" ||
            col.gameObject.name == "OrangeIdentifier(Clone)" ||  col.gameObject.name == "GreenIdentifier(Clone)" || col.gameObject.name == "PurpleIdentifier(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
