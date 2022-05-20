using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoire : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameState == GameManager.state.victory)
        {
            //active le canvas de la victoire
            GameManager.instance.usingSomething = true;
            canvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
