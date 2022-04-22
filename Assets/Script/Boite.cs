using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// classe boite herite de mono
/// </summary>
public class Boite : MonoBehaviour
{
    float speed = 1f;
    float zRotation = 0f;
    bool ouvert = false;
    private bool goodCode = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ouvert == false&& goodCode==true)
        {
            Ouvrir();
        }
}
    void Ouvrir()
    {
        
            Destroy(this.gameObject);
        
        
            ouvert = true;
        
    }
    public void Code()
    {
        goodCode = true;
    }


}

