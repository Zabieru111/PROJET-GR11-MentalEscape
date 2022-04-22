using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            fermerCanvas();
        }
       
    }

    public void activate()
    {
            canvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
    }
    public void fermerCanvas()
    {
        canvas.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
