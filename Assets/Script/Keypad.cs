using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public string answer;
    private string myAnswer = "";
    private int nombreClick = 0;
    public GameObject canvas;
    public GameObject GameObject;
    public Text text;
    private bool answered = false;
    public int type;
    public float cordx;
    public float cordy;
    public float cordz;
    private bool state = false;

    public void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape)&&state==true)
        {
            fermerCanvas();
        }
    }
    //ouvre le canvas du keypad
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
    //change my answer en rajoutant la valeur du bouton pressé  
    public void clickButton(GameObject button)
    {
        if (nombreClick < 8)
        {
            
            nombreClick++;
            myAnswer = myAnswer + button.name;
            editMessage();
        }
    }
    //enleve la valeur du dernier bouton pressé a myanswer
    public void undo()
    {
        if (nombreClick > 0)
        {
            nombreClick--;
            myAnswer = myAnswer.Substring(0, nombreClick);
            editMessage();
        }
    }
    //effectue l'action souhaité si la réponse est la bonne
    public void checkAndswer()
    {
        
        if (answer == myAnswer)
        {
            answered = true;
            fermerCanvas();
            if(type == 1){
                porte porte = new porte();
                porte = GameObject.GetComponent<porte>();
                porte.Code();
            }else if(type == 2){
                Boite boite = new Boite();
                boite = GameObject.GetComponent<Boite>();
                boite.Code();
            }else if(type == 3){
                //détruire l'objet et ouvre la boite
                Boite boite = new Boite();
                boite = GameObject.GetComponent<Boite>();
                boite.Code();
                Destroy(this.gameObject);
            }else if(type == 4){
                Obtenable o1 = new Obtenable();
                o1 = GameObject.GetComponent<Obtenable>();
                o1.accessible();
            }
            else if (type == 11)
            {
                //fait apparaitre un objet dans les coordonnées décidés
                Instantiate(GameObject, new Vector3(cordx, cordy, cordz), Quaternion.identity);
            }
            
        }
    }
    public void editMessage()
    {
        text.text = myAnswer;
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
