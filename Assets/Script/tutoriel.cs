using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutoriel : MonoBehaviour
{
    public Canvas canvas;
    public Text etape1;
    public Text etape2;
    public Text etape3;
    private bool w = false;
    private bool a = false;
    private bool s = false;
    private bool d = false;
    private float position;
    private RayCast interagir;
    private GameObject game;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            w = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            a = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            s = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            d = true;
        }
        if (w && a && s && d&&etape1.enabled==true)
        {
            etape1.enabled = false;
            etape2.enabled = true;
            position = Camera.main.transform.rotation.x;
            
        }
        
        if (etape2.enabled == true)
        {
            if (position != Camera.main.transform.rotation.x)
            {
                etape2.enabled = false;
                etape3.enabled = true;

            }
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            etape3.enabled = false;
        }
    }
}
