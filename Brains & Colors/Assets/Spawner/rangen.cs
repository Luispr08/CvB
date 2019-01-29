using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangen : MonoBehaviour
{
    public static int n1, n2, n3, n4, n5, n6, n7, Ident;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void level1()
    { }
    public void level2()
    { }
    public void level3()
    { }
    public void level4()
    { }
    public static void rangenerator()
    {
        List<int> Rnumbers = new List<int>(new int[] { 1, 2, 3, 4, 5 });

        n1 = Rnumbers[Random.Range(0, Rnumbers.Count)];
        Rnumbers.Remove(n1);
        n2 = Rnumbers[Random.Range(0, Rnumbers.Count)];
        Rnumbers.Remove(n2);
        n3 = Rnumbers[Random.Range(0, Rnumbers.Count)];
        Rnumbers.Remove(n3);
        n4 = Rnumbers[Random.Range(0, Rnumbers.Count)];
        Rnumbers.Remove(n4);
        n5 = Rnumbers[Random.Range(0, Rnumbers.Count)];
        Rnumbers.Remove(n5);

        /*if (score >= 50000)//Add a color makes it "harder"
        {
            //We want to add the 6th color
            Rnumbers.Add(6);
            n6 = Rnumbers[Random.Range(0, Rnumbers.Count)];
            Rnumbers.Remove(n6);
        }
        if (score >= 100000) //Add a color makes it "harder"
        {
            //We want to add the 7th color
            Rnumbers.Add(7);
            n7 = Rnumbers[Random.Range(0, Rnumbers.Count)];
            Rnumbers.Remove(n7);
        }*/

        //Debug.Log("Random values:" + n1 + n2 + n3 + n4 + n5);

        System.Random r = new System.Random();
        if (score < 50000)
        {
            var values = new[] { n1, n2, n3, n4, n5 };
            Ident = values[r.Next(values.Length)];
        }
        /*if (score >= 50000)
        {
            var values = new[] { n1, n2, n3, n4, n5,n6 };
            Ident = values[r.Next(values.Length)];
        }
        if (score >= 100000)
        {
            var values = new[] { n1, n2, n3, n4, n5, n6, n7 };
            Ident = values[r.Next(values.Length)];
        }*/

        //Debug.Log("This is Indent value:" +Ident);
    }
}
