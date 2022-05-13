using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPVictoire : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;
    public porte porte;
     //Permet de terminer la partie si le joueur entre en collision avec une zone
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
        porte.ouvert = true;
    }
}
