using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    
    //public GameObject TorF;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == this.tag)
       {
            //If this happens the player loses the game. This mean the player didnt click on the matching colors.
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
        else
        { 
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
           
        }
    }

    
}
