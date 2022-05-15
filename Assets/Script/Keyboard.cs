using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public string answer; //la réponse (mot de passe)
    private string myAnswer; //ce que le joueur a écrit
    public GameObject canvas; //le canvas pour écrire le mot de passe
    public GameObject GameObject; //l'objet à débloquer
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
    public void ReadStringInput(string texte){ //lit ce qui est inscrit par le joueur
        myAnswer = texte;
    }
    public void checkAndswer()
    {
        
        if (answer == myAnswer)
        {//si la réponse est bonne, la boite s'ouvre.
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

