using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTouch : MonoBehaviour
{
    public  float cubesize = 0.2f;
    public  int cubesinRow = 5;
    public  int explosionForce = 50;
    public  int explosionRadius = 5;
    public  float explosionUpward = 0.5f;
    GameObject pieces;
    Renderer material;
    public  float cubesPivotDistance;
    Vector3 cubePivot;
    // Start is called before the first frame update
    void Start()
    {
        cubesPivotDistance = cubesize * cubesinRow / 2;

        cubePivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnDestroy()
    {
        explode();

    }

    public void explode()
    {
        for (int x = 0; x < cubesinRow; x++)
        {
            for (int y = 0; y < cubesinRow; y++)
            {
                for (int z = 0; z < cubesinRow; z++)
                {
                    cubetouch(x,y,z);
                }
            }
        }
        Vector3 explosionPos = transform.position;

        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
            
        }
        


    }
    public void cubetouch(int x, int y, int z)
    {

                    pieces = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    pieces.tag = "smallcubes";
                    pieces.layer = 10;
                    pieces.GetComponent<Renderer>().material.color = this.gameObject.GetComponent<Renderer>().material.color;
                    pieces.transform.position = transform.position + new Vector3(cubesize * x, cubesize * y, cubesize * z) - cubePivot;
                    pieces.transform.localScale = new Vector3(cubesize, cubesize, cubesize);


                    pieces.AddComponent<Rigidbody>();
                    pieces.GetComponent<Rigidbody>().mass = cubesize;


        Destroy(pieces, 2.0f);
    }
    

}
