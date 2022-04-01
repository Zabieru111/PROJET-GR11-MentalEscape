using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question : MonoBehaviour
{
    public GameObject canvas;
    private bool ouvert = false;
    private void Update()
    {
        if (ouvert ==true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                canvas.SetActive(false);
            }
        }
    }
    public void activate()
    {
        print("yep");
        canvas.SetActive(true);
        ouvert = true;
    }
}
