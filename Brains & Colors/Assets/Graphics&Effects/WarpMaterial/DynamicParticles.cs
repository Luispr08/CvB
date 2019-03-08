using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicParticles : MonoBehaviour
{
    public ParticleSystem Lights;
    public ParticleSystem.MainModule Lightsmain;

   //Check the color 32 value by looking at the colors in the inspector then add the values to the color32 variales in script based on the value shown in the inspector.

    public Color red = new Color32(255, 0, 0, 255);
    public Color green = new Color32(0, 255, 0, 255);
    public Color yellow = new Color32(255, 255, 0, 255);
    public Color pink = new Color32(255, 0, 255, 255);
    public Color lightBlue = new Color32(0,255,255,255);
    public Color blue = new Color32(0,0,255,255);

    public float time = 0.0f;

    public int RanNum = 1;
    //Combinations:
    //**Pink and Red
    //**Blue and Light Blue
    //**Yellow and blue
    //**Green and blue

    void Start()
    {
        Lights = GetComponent<ParticleSystem>();
        Lightsmain = Lights.main; 
    }

    // Update is called once per frame
    void Update()
    {
         
        var startcolor = Lightsmain.startColor;


        time += Time.deltaTime;
        if (time >= 10f)
        {
            RanNum += 1;
            if (RanNum > 4)
            {
                RanNum = 1;
            }
        }
        if (RanNum == 1)
        {
            startcolor.colorMin = blue;
            startcolor.colorMax = lightBlue;

            Lightsmain.startColor = startcolor;
        }
        else if (RanNum == 2)
        {
            startcolor.colorMin = pink;
            startcolor.colorMax = red;

            Lightsmain.startColor = startcolor;
        }
        else if (RanNum == 3)
        {
            startcolor.colorMin = yellow;
            startcolor.colorMax = blue;

            Lightsmain.startColor = startcolor;
        }
        else if(RanNum ==4)
        {
            startcolor.colorMin = green;
            startcolor.colorMax = blue;

            Lightsmain.startColor = startcolor;
        }
        time = time % 10;
    }

   
}
