using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    //S for sphere
    public GameObject YellowS;
    public GameObject RedS;
    public GameObject BlueS;
    public GameObject PinkS;
    public GameObject OrangeS;
    public GameObject GreenS;
    public GameObject PurpleS;

    //Spawn points
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;

    //IdentSpawnPoints
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

    // Start is called before the first frame update
    void Start()
    {
        //Find objects that will be used in this script
        YellowS = Resources.Load<GameObject>("Objects/Spheres/YellowSphere");
        RedS = Resources.Load<GameObject>("Objects/Spheres/RedSphere");
        BlueS = Resources.Load<GameObject>("Objects/Spheres/BlueSphere");
        PinkS = Resources.Load<GameObject>("Objects/Spheres/PinkSphere");
        OrangeS = Resources.Load<GameObject>("Objects/Spheres/OrangeSphere");
        GreenS = Resources.Load<GameObject>("Objects/Spheres/GreenSphere");
        PurpleS = Resources.Load<GameObject>("Objects/Spheres/PurpleSphere");

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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
