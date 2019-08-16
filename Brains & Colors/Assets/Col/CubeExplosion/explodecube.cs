using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodecube : MonoBehaviour
{
    public float cubeSize = 0.2f;
    public int CubesInRow = 5;

    public float cubesPivotDistance;
    Vector3 cubesPivot;
    // Start is called before the first frame update
    void Start()
    {
        cubesPivotDistance = cubeSize * CubesInRow / 2;

        cubesPivot = new Vector3(cubesPivotDistace, cubesPivotDistance, cubesPivotDistance );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   static public void explode()
    {
        gameObject.SetActive(false);

        for (int x = 0; x < CubesInRow; x++)
        {
            for(int y=0; x<CubesInRow; y++)
            {
                for(int z=0; z<CubesInRow; z++)
                {
                    createPiece(x,y,z);
                }
           
            }
        }

        Vector3 explosionPos = transform.position;

        Collider[] collider = Physics.OverlapSphere(explosionPos, explosionRadius);

        foreach (Collider hit in colliders)
        {
            Ridigbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null) {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }
    }

    public void createPiece(int x, int y, int z)
    {
        GameObject piece;
        piece = GameObject.CreatePrimite(PrimitiveType.Cube);

        piece.transform.position = transform.position + new Vector3(cubeSize *x, cubeSize*y,cubeSize*z ) -cubesPivot;

        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);


        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>.mass = cubeSize;
    }
}
