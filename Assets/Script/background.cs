using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    private float speed = 0.005f;
    //fait tourner la salle du menu principale
    void Update()
    {
        this.transform.Rotate(0f,speed,0f); 
    }
}
