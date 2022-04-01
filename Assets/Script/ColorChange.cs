using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject gameObject;
    float timeLeft;
    float minutes;
    Color targetColor;

    private void Start()
    {
        
        minutes = GameManager.instance.minutes;
    }
    void Update()
    {
        var renderer = gameObject.GetComponent<Renderer>();
        if (timeLeft <= Time.deltaTime && minutes==0f)
        {
            // transition complete
            // assign the target color
            renderer.material.color = targetColor;

            // start a new transition
            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        }
        else
        {
            // transition in progress
            // calculate interpolated color
            renderer.material.color = Color.Lerp(renderer.material.color, targetColor, Time.deltaTime / timeLeft);

            // update the timer
            timeLeft -= Time.deltaTime;
        }
    }
}


