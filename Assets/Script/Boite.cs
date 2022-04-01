using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// classe boite herite de mono
/// </summary>
public class Boite : MonoBehaviour
{
    public GameObject gameObject;
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
        if (transform.localRotation.z < 0.5)
        {
            Destroy(this.gameObject);
        }
        else
        {
            ouvert = true;
        }
    }
    public void Code()
    {
        goodCode = true;
    }


}

