using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSPawner2 : MonoBehaviour
{
    //List to choose cubes from.
    public List<GameObject> spheres;
    public List<GameObject> SphereIdentifiers;
    //S for sphere
    public GameObject YellowS;
    public GameObject RedS;
    public GameObject BlueS;
    public GameObject PinkS;
    public GameObject OrangeS;
    public GameObject GreenS;
    public GameObject PurpleS;

    //spehere Spawn points
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;

    //Identifiers SpawnPoints
    public GameObject S1;
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;
    public GameObject S5;

    //Sphere Identifiers
    public GameObject YellowIdent;
    public GameObject RedIdent;
    public GameObject BlueIdent;
    public GameObject PinkIdent;
    public GameObject OrangeIdent;
    public GameObject GreenIdent;
    public GameObject PurpleIdent;

    public static bool spawnCTRL;
    public float t = 0.0f;

    public static GameObject objIdent2;
    public GameObject objIname2;
    // Start is called before the first frame update
    public void Start()
    {
      

        //Find objects that will be used in this script
        YellowS = Resources.Load<GameObject>("Objects/spheres/YellowSphere");
        RedS = Resources.Load<GameObject>("Objects/spheres/RedSphere");
        BlueS = Resources.Load<GameObject>("Objects/spheres/BlueSphere");
        PinkS = Resources.Load<GameObject>("Objects/spheres/PinkSphere");
        OrangeS = Resources.Load<GameObject>("Objects/spheres/OrangeSphere");
        GreenS = Resources.Load<GameObject>("Objects/spheres/GreenSphere");
        PurpleS = Resources.Load<GameObject>("Objects/spheres/PurpleSphere");

        //Finds spawnpoints that will be used in this script
        S1 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnIdentSphere1");
        S2 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnIdentSphere2");
        S3 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnIdentSphere3");
        S4 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnIdentSphere4");
        S5 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnIdentSphere5");

        s1 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint1");
        s2 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint2");
        s3 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint3");
        s4 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint4");
        s5 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint5");

        //Finds identifiers
        YellowIdent = Resources.Load<GameObject>("Objects/SphereIdentifiers/YellowIdentifier");
        RedIdent = Resources.Load<GameObject>("Objects/SphereIdentifiers/RedIdentifier");
        BlueIdent = Resources.Load<GameObject>("Objects/SphereIdentifiers/BlueIdentifier");
        PinkIdent = Resources.Load<GameObject>("Objects/SphereIdentifiers/PinkIdentifier");
        OrangeIdent = Resources.Load<GameObject>("Objects/SphereIdentifiers/OrangeIdentifier");
        GreenIdent = Resources.Load<GameObject>("Objects/SphereIdentifiers/GreenIdentifier");
        PurpleIdent = Resources.Load<GameObject>("Objects/SphereIdentifiers/PurpleIdentifier");

        spawnCTRL = true;
    }

    // Update is called once per frame
    public void Update()
    {
        //For testing purposes we need to specify speed here. Later on I'm gonna change it to depending the level.
        MoveObject.speed = -2;
        
        spheres = new List<GameObject> {YellowS, RedS, BlueS, GreenS, PinkS, OrangeS, PurpleS };
        SphereIdentifiers = new List<GameObject> {YellowIdent, RedIdent, BlueIdent, GreenIdent, PinkIdent, OrangeIdent, PurpleIdent};
        //Each sphere and spawn point have to have their own timer so that they can spawn faster or slower depending on their randomized time.
        //Spawn a sphere and its corresponding identifier.
        int rand_i;
        int rand_s = Random.Range(0, spheres.Count); //Chooses a sphere

        int yesorno = Random.Range(0, 3);
        if (yesorno == 0) //1 out of 4 should be equal.
        {
            rand_i = rand_s;
        }
        else
        {
            rand_i = Random.Range(0, SphereIdentifiers.Count); //Chooses a spawn point color.
        }
        if (spawnCTRL == true) //If this is true then we want to spawn 
        {
            t += Time.deltaTime;
            

            if (t >= 1f) //Spawn after one second.
            {
                
                objIdent2 = Instantiate(spheres[rand_s], this.transform.position+(new Vector3(0, 15, 0)), transform.rotation); // This will spawn sphere at position + units
                objIdent2.gameObject.name = "S2";
                objIname2 = Instantiate(SphereIdentifiers[rand_i], this.transform.position, transform.rotation); //This will spawn the sphere Identifiers.
                objIname2.gameObject.name = "S2I";
                spawnCTRL = false;
            }
        t = t % 1;

    
        }
      
    }
    

}

