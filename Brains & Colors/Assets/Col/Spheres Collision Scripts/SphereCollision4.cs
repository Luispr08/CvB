using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision4 : MonoBehaviour
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
            if (SSPawner1.objIdent1.gameObject.name == this.gameObject.name)
            {
                SSPawner1.spawnCTRL = true;
               
            }
            else if (SSPawner2.objIdent2.gameObject.name == this.gameObject.name)
            {
                SSPawner2.spawnCTRL = true;
                
            }
            else if (SSPawner3.objIdent3.gameObject.name == this.gameObject.name)
            {
                SSPawner3.spawnCTRL = true;
               
            }
            else if (SSPawner4.objIdent4.gameObject.name == this.gameObject.name)
            {
                SSPawner4.spawnCTRL = true;
                
            }
            else if (SSPawner5.objIdent5.gameObject.name == this.gameObject.name)
            {
                SSPawner5.spawnCTRL = true;
                
            }
            //If this happens the player loses the game. This mean the player didnt click on the matching colors.
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
        else
        {
            if (SSPawner1.objIdent1.gameObject.name == this.gameObject.name)
            {
                SSPawner1.spawnCTRL = true;
               
            }
            else if (SSPawner2.objIdent2.gameObject.name == this.gameObject.name)
            {
                SSPawner2.spawnCTRL = true;
                
            }
            else if (SSPawner3.objIdent3.gameObject.name == this.gameObject.name)
            {
                SSPawner3.spawnCTRL = true;
               
            }
            else if (SSPawner4.objIdent4.gameObject.name == this.gameObject.name)
            {
                SSPawner4.spawnCTRL = true;
               
            }
            else if (SSPawner5.objIdent5.gameObject.name == this.gameObject.name)
            {
                SSPawner5.spawnCTRL = true;
                
            }
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
           
        }
    }

    
}
