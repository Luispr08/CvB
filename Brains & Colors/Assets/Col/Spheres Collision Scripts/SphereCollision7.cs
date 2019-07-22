using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision7 : MonoBehaviour
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
            if (collision.gameObject.name == "S1I")
            {
                SSPawner1.spawnCTRL = true;

            }
            else if (collision.gameObject.name == "S2I")
            {
                SSPawner2.spawnCTRL = true;

            }
            else if (collision.gameObject.name == "S3I")
            {
                SSPawner3.spawnCTRL = true;

            }
            else if (collision.gameObject.name == "S4I")
            {
                SSPawner4.spawnCTRL = true;

            }
            else if (collision.gameObject.name == "S5I")
            {
                SSPawner5.spawnCTRL = true;

            }
            //If this happens the player loses the game. This mean the player didnt click on the matching colors.
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            
        }
        else
        {
            if (collision.gameObject.name == "S1I")
            {
                SSPawner1.spawnCTRL = true;
               
            }
            else if (collision.gameObject.name == "S2I")
            {
                SSPawner2.spawnCTRL = true;
                
            }
            else if (collision.gameObject.name == "S3I")
            {
                SSPawner3.spawnCTRL = true;
                
            }
            else if (collision.gameObject.name == "S4I")
            {
                SSPawner4.spawnCTRL = true;
                
            }
            else if (collision.gameObject.name == "S5I")
            {
                SSPawner5.spawnCTRL = true;
                
            }
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
           
        }
    }

    
}
