using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestOnTime : MonoBehaviour
{
    public float DestroyTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }

}
