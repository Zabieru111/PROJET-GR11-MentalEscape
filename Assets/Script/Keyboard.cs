using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public string answer;
    private string myAnswer;
    public GameObject canvas;
    public GameObject GameObject;
    private bool answered = false;
    private bool state = false;

    public void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape) && state == true)
        {
            fermerCanvas();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            checkAndswer();
        }
    }
    public void utiliser()
    {
        if (answered==false)
        {
            canvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            GameManager.instance.changeUsing();
            state = true;
        }

    }
    public void ReadStringInput(string texte){
        myAnswer = texte;
    }
    public void checkAndswer()
    {
        
        if (answer == myAnswer)
        {
            answered = true;
            fermerCanvas();
            int i = 9;
            Debug.Log(i);
            Boite boite = new Boite();
            boite = GameObject.GetComponent<Boite>();
            boite.Code();
            Destroy(this.gameObject);
        }
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

