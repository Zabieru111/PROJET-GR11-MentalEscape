using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;
    //Permet de télé^porter le joueur à la position d'un objet
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
            
    }
}
