using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoire : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameState == GameManager.state.victory)
        {
            GameManager.instance.usingSomething = true;
            canvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
