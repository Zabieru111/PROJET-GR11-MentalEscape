using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porte : MonoBehaviour
{
    public GameObject gameObject;
    float speed = 0.1f;
    float zRotation = 0f;
    public bool ouvert = false;
    private bool goodCode = false;
    // Update is called once per frame
    public void Update()
    {
        if (ouvert == false&& goodCode==true)
        {
            Ouvrir();
        }
     
    }
    public void Ouvrir()
    {
        if (transform.localRotation.z < 0.5)
        {
            gameObject.transform.Rotate(0f, 0f, speed);
        }
        else
        {
            ouvert = true;
        }
        
    }
    public void Code()
    {
        goodCode = true;
    }
}
