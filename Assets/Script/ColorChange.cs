using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject gameObject;
    float timeLeft;
    public Color targetColor;
    float densite = 0f;
    float minutes;
    float secondes;
    public static ColorChange instance;


    void Update()
    {
        minutes = GameManager.instance.minutes;
        secondes = GameManager.instance.secondes;

        RenderSettings.fogDensity = densite;
        RenderSettings.fog = true;

        // var renderer = gameObject.GetComponent<Renderer>();
        // && minutes == 9 && secondes <= 58f
        if (timeLeft <= Time.deltaTime)
        {
            // transition complete
            // assign the target color
            //renderer.material.color = targetColor;
            RenderSettings.fogColor = targetColor;

            // start a new transition
            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 2.0f;
            densite = densite + 0.001f;
        }
        else
        {
            // transition in progress
            // calculate interpolated color
            // renderer.render.color = Color.Lerp(renderer.material.color, targetColor, Time.deltaTime / timeLeft);
            RenderSettings.fogColor = Color.Lerp(RenderSettings.fogColor, targetColor, Time.deltaTime / timeLeft);
            // update the timer
            timeLeft -= Time.deltaTime;
        }
    }
}

