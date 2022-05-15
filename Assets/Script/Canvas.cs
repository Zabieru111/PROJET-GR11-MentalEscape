using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject canvas; //le canvas à afficher
    private bool state = false;//si le canvas est activé

    public void Update()
    {
        //si le canvas est ouvert et escape est pressé
        if (Input.GetKeyDown(KeyCode.Escape) && state == true)
        {
            fermerCanvas();//il sort du canvas
        }
       
    }

    public void activate()
    {
        canvas.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        GameManager.instance.changeUsing();
        state = true;
    }
    public void fermerCanvas()
    {
        canvas.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameManager.instance.changeUsing();
        state = false;
    }
}
