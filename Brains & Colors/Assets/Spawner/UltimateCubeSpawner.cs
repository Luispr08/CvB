using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateCubeSpawner : MonoBehaviour
{
    //Make a list of the SpawnPoints so that I can choose where to spawn.
    //Make a list of the Colored Cubes so I can choose what to spawn.
    //Make a list of 5 random generate numbers.
    //Make a list of the colored rectangles identifiers so I can choose which cube must be destroyed.
    // Start is called before the first frame update

    public List<GameObject> Cubes;
    public List<GameObject> SpawnPoints;
    public List<GameObject> RectangleIdentifiers;

    public GameObject YellowCube;
    public GameObject RedCube;
    public GameObject BlueCube;
    public GameObject PinkCube;
    public GameObject OrangeCube;
    public GameObject GreenCube;
    public GameObject PurpleCube;

    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;

    public GameObject YellowRectangle;
    public GameObject RedRectangle;
    public GameObject BlueRectangle;
    public GameObject PinkRectangle;
    public GameObject OrangeRectangle;
    public GameObject GreenRectangle;
    public GameObject PurpleRectangle;

    public GameObject si; //Identifier spawn

    public List<int> SpawnedIndexes;
    public GameObject LiveDecreaser;
    public int LVL = 5;
    private float time = 0.0f;
    void Start()
    {
        //I grab all the obejcts that I need including the spawn points and I put them all in a list.
        YellowCube = Resources.Load<GameObject>("Objects/Cubes/YellowCube");
        RedCube = Resources.Load<GameObject>("Objects/Cubes/RedCube");
        BlueCube = Resources.Load<GameObject>("Objects/Cubes/BlueCube");
        PinkCube = Resources.Load<GameObject>("Objects/Cubes/PinkCube");
        OrangeCube = Resources.Load<GameObject>("Objects/Cubes/OrangeCube");
        GreenCube = Resources.Load<GameObject>("Objects/Cubes/GreenCube");
        PurpleCube = Resources.Load<GameObject>("Objects/Cubes/PurpleCube");

        YellowRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/YellowIdentifier");
        RedRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/RedIdentifier");
        BlueRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/BlueIdentifier");
        PinkRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/PinkIdentifier");
        OrangeRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/OrangeIdentifier");
        GreenRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/GreenIdentifier");
        PurpleRectangle = Resources.Load<GameObject>("Objects/RectangleIdentifiers/PurpleIdentifier");

        s1 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint1");
        s2 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint2");
        s3 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint3");
        s4 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint4");
        s5 = Resources.Load<GameObject>("Objects/SpawnPoints/SpawnPoint5");
        si = Resources.Load<GameObject>("Objects/SpawnPoints/IdentifierSpawnPoint");

        LiveDecreaser = Resources.Load<GameObject>("Objects/Cubes/LivesUpdater");

        
        //These are the lists.
        //Cubes = new List<GameObject> {YellowCube,RedCube,BlueCube,PinkCube,OrangeCube,GreenCube,PurpleCube};
        //SpawnPoints = new List<GameObject> {s1,s2,s3,s4,s5};
        //RectangleIdentifiers = new List<GameObject> {YellowRectangle, RedRectangle, BlueRectangle, PinkRectangle, OrangeRectangle, GreenRectangle, PurpleRectangle};
    }

    // Update is called once per frame
    void Update()
    {
        //These are the lists.
        Cubes = new List<GameObject> { YellowCube, RedCube, BlueCube, PinkCube, OrangeCube, GreenCube, PurpleCube };
        SpawnPoints = new List<GameObject> { s1, s2, s3, s4, s5 };
        RectangleIdentifiers = new List<GameObject> { YellowRectangle, RedRectangle, BlueRectangle, PinkRectangle, OrangeRectangle, GreenRectangle, PurpleRectangle };
        SpawnedIndexes = new List<int>();

        //Now that I have this list I have to develop a way to spawn this cubes once, or more than once. Basically I have to control how many times can we spawn the same color (depending on level!)
        time += Time.deltaTime;

        if (time >= 2f)
        {
            for (int Numcubes = 0; Numcubes < LVL; Numcubes++)
            {
                int obj = Random.Range(0, Cubes.Count); //Obtain the index of the cube that we want to spawn.

                int s_obj = Random.Range(0, SpawnPoints.Count);//Obtain the index of the spawnpoint where we want to spawn the cube.

                Instantiate(Cubes[obj], SpawnPoints[s_obj].transform.position, transform.rotation); //Instiate the cube of the selected index, at the position of the spawn point. 
                    
                selection(obj);
                Cubes.Remove(Cubes[obj]); //Removes item in order to avoid repetitiono of the same object (this will change in the future as I have to spawn two of the same color to make the game harder)
                SpawnPoints.Remove(SpawnPoints[s_obj]); // Removes spawn point so we dont spawn two cubes at the same location.

                //Stores the indexes of the objects
                

                if (Numcubes + 1 == LVL) //Required in order to instantiate one identifier at a time.
                {
                    int IdentObj = Random.Range(0,SpawnedIndexes.Count); //Finds a random index from the rectangles list and spawns one. The negative number is to avoide spawning the green and purple rectangle as they belong to a higher level.

                    Instantiate(RectangleIdentifiers[IdentObj], si.transform.position, transform.rotation);

                    Instantiate(LiveDecreaser, s3.transform.position, transform.rotation); //Spawn lives decreaser object only once.
                }

            }

            time = time % 1;
        }

    }

    public void selection(int obj)
    {
        if (Cubes[obj] == YellowCube)
        {
            SpawnedIndexes.Add(0);
        }
        else if (Cubes[obj] == RedCube)
        {
            SpawnedIndexes.Add(1);
        }
        else if (Cubes[obj] == BlueCube)
        {
            SpawnedIndexes.Add(2);
        }
        else if (Cubes[obj] == PinkCube)
        {
            SpawnedIndexes.Add(3);
        }
        else if (Cubes[obj] == OrangeCube)
        {
            SpawnedIndexes.Add(4);
        }
        else if (Cubes[obj] == GreenCube)
        {
            SpawnedIndexes.Add(5);
        }
        else if (Cubes[obj] == PurpleCube)
        {
            SpawnedIndexes.Add(6);
        }
    }
    
}
