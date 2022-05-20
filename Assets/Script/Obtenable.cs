using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obtenable : MonoBehaviour
{
    public GameObject plancher; 
    private float radius;
    private bool picked = false;
    private bool taken = false;
    private bool clear;
    public int type;
    private float x;
    private float y;
    private float z;

    void Start()
    {
        x = this.x;
        y = this.y;
        z = this.z;
        if (type == 1)
        {
            clear = false;
        }
        else
        {
            clear = true;
        }
    }
    private void Update()
    {
if (this.transform.position.y <= plancher.transform.position.y+0.27f)
       {
           this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
       }
//l'objet pris suit la caméra du joueur
        if (picked == true)
        {
            this.transform.position = Camera.main.transform.position 
           + Camera.main.transform.forward * radius;

        }
        // lacher avec le clic droit de la souris
        if (Input.GetMouseButtonDown(1))
        {
            picked = false;
            this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        }

    }
    //prend l'objet et le souleve
    public void prendre()
    {
        if (clear)
        {
            calculerDistance();
            picked = true;
            if (this.name.Contains("key") && taken == false)
            {
                GameManager.instance.addKey();
                taken = true;
            }
        }
        
        
    }
    public void accessible()
    {
        clear = true;
    }
    private void calculerDistance()
    {
        radius = 3.0f;
    }

}
