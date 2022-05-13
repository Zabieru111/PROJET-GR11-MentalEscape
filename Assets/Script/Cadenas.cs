using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class Cadenas : MonoBehaviour
{
    public GameObject cle;
    public GameObject effet;
    public GameObject GameObject;
    public GameObject otherShelf;
    //si jamais le cadenas ouvre seulement si l'autre cadenas est ouvert
    public int type;
    private bool test=false;
    //si le cadenas est ouvert ou non.
    public float cordx;
    public float cordy;
    public float cordz;

    void Update()
    {
        if (test==false)//seulement si le cadenas n'est pas d�bloqu�
      {
            if (Mathf.Sqrt((this.transform.position.x - cle.transform.position.x) * (this.transform.position.x - cle.transform.position.x) +
            (this.transform.position.z - cle.transform.position.z) * (this.transform.position.z - cle.transform.position.z) +
            (this.transform.position.y - cle.transform.position.y) * (this.transform.position.y - cle.transform.position.y)) < 1f)
            {
                Destroy(cle);
                deverouiller();

            }
        }
        
    }
    void deverouiller()
    {
        
        if (type == 1)
        {
            porte porte = new porte();
            porte = effet.transform.GetComponent<porte>();
            porte.Code();
        } else if (type == 2) {
            Boite boite = new Boite();
            boite = effet.GetComponent<Boite>();
            boite.Code();
        }
        else if (type == 3)
        {
            Tiroir tiroir = new Tiroir();
            tiroir = effet.GetComponent<Tiroir>();
            tiroir.code();   
        }
        else if (type == 4)
        {
            //d�truit le cadenas
            Destroy(GameObject);
        }

        if (type == 11)
        {
            //met la cl� (qui est un livre) sur sa place dans l'�tag�re
            Instantiate(cle, new Vector3(cordx,cordy,cordz), Quaternion.identity);
            test=true;
            Cadenas cad = new Cadenas();
            //prend en compte de l'autre cadenas
            cad = otherShelf.GetComponent<Cadenas>();
            if(cad.verif()==true){
                //si l'autre est aussi ouvert, l'objet � faire apparaitre apparait.
                Instantiate(GameObject, new Vector3((float)-12.2, (float)3.934197, (float)-20.3), Quaternion.identity);
            }

        }else{
            
            Destroy(this.gameObject);
        }
    
    }
    bool verif(){
        //retourne si le cadenas est d�bloqu� ou non.
        return test;
    }
}
