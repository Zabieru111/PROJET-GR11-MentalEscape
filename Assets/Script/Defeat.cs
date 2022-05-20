using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defeat : MonoBehaviour
{
    public GameObject canvas;
    private bool defeat;
    // Start is called before the first frame update
    void Start()
    {
        defeat = false;
    }

    // Update is called once per frame
    //fait apparaitre le canvas de la d�faitre quand le temps du manager atteint 0
    void Update()
    {

        if (GameManager.instance.minutes == 0 && GameManager.instance.secondes <= 0f && defeat == false)
        {
            GameManager.instance.usingSomething = true;
            GameManager.instance.Defeat();
            canvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            defeat = true;
           


        }
    }
}
