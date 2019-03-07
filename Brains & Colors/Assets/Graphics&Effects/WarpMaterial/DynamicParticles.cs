using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicParticles : MonoBehaviour
{
    public ParticleSystem Lights;
    public ParticleSystem.MainModule Lightsmain;

   //Check the color 32 value by looking at the colors in the inspector then add the values to the color32 variales in script based on the value shown in the inspector.

    public Color32 red;
    public Color32 green = new Color32(0, 255, 0, 255);
    public Color32 yellow;
    public Color32 pink;
    public Color32 purple;
    public Color32 lightBlue = new Color32(0,255,255,255);
    public Color32 blue = new Color32(0,0,255,255);
    void Start()
    {
        Lights = GetComponent<ParticleSystem>();
        Lightsmain = Lights.main;
        
        
        
       

  
    }

    // Update is called once per frame
    void Update()
    {
        var startcolor = Lightsmain.startColor;

        startcolor.colorMin = blue;
        startcolor.colorMax = lightBlue;

       Lightsmain.startColor = startcolor;
    }

   
}
