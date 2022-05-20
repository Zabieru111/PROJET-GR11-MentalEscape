using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampe : MonoBehaviour
{
    public Light light;
    //active la lumière
    public void changer()
    {
        light.enabled = !light.enabled;
    }
}
