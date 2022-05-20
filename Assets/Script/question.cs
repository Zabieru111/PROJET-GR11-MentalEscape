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
                ouvert = false;
                canvas.SetActive(false);
                GameManager.instance.changeUsing();
            }
        }
    }
    //ouvre le canvas de la question
    public void activate()
    {
        GameManager.instance.changeUsing();
        canvas.SetActive(true);
        ouvert = true;
    }
}
