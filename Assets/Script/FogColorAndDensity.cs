using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogColorAndDensity : MonoBehaviour
{
    // Start is called before the first frame update
    public Color color;
    public float densite;
    public float temps;

     

    void Start()
    {
        RenderSettings.fogColor = color;
        RenderSettings.fogDensity = densite;
        RenderSettings.fog = true;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
