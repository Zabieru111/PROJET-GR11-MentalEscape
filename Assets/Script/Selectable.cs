using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public int type;
    public GameObject Object;
    // Start is called before the first frame update
    public void Interagir()
    {
        //type pour keypad
       if (type == 1)
        {          
            Object.GetComponent<Keypad>().utiliser();           
        }
       //type pour obtenable
       if (type == 2)
        {   
            Object.transform.GetComponent<Obtenable>().prendre();         
        }
       //type pour lampe
       if(type == 3)
        {         
            Object.GetComponent<Lampe>().changer();
        }
       //type pour question
       if (type == 4)
        {
            
            Object.GetComponent<question>().activate();
        }
        //type pour levier
        if (type == 5)
        {

            Object.GetComponent<Levier>().activate();
        }
        //type pour question2
        if (type == 6)
        {

            Object.GetComponent<Canvas>().activate();
        }
        if (type == 7)
        {
            //type pour keyboard
            Object.GetComponent<Keyboard>().utiliser();
        }
        if (type == 8)
        {
            //type pour retourner au main
            Object.GetComponent<BackToMenu>().clickBackMenu();
        }
    }
}
