using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricEffectOnTouch : MonoBehaviour
{
    public GameObject TouchEffect;
    public GameObject particleDestroyer;
    // Start is called before the first frame update
    public bool isQuitting;
   
    void Start()
    {
        TouchEffect = Resources.Load<GameObject>("Objects/ElectricParticleExplosion/FastElectricExplosion");
        
    }

    // Update is called once per frame
    void Update()
    {
        //particleDestroyer = GameObject.Find("FastElectricExplosion(Clone)");
       // Destroy(particleDestroyer,0.5f);

    }
    private void OnApplicationQuit()
    {
        isQuitting = true;
    }
    public void OnDestroy()
    {
        if (!isQuitting)
        {
            Destroy(Instantiate(TouchEffect, transform.position, transform.rotation), 1f);
        }
    }
}
