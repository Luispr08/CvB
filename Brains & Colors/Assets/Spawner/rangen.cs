using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangen : MonoBehaviour
{
    public static int n1, n2, n3, n4, n5, n6, n7, Ident;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void rangenerator()
    {
        n1 = Random.Range(1,5);
        n2 = Random.Range(1,5);
        n3 = Random.Range(1,5);
        n4 = Random.Range(1,5);
        n5 = Random.Range(1,5);

        Debug.Log("Random values:" + n1 + n2 + n3 + n4 + n5);
        System.Random r = new System.Random();
        var values = new[] { n1, n2, n3, n4, n5 };
        Ident = values[r.Next(values.Length)];


        Debug.Log("This is Indent value:" +Ident);
    }
}
