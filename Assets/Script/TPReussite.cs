using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPReussite : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject barriere;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
        Destroy(barriere);
    }
}
