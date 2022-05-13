using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpmauvaise : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
    public GameObject Camera;
    public Transform teleportTarget;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if(FloatingTextPrefab)
        {
            ShowFloatingText();
            Destroy(FloatingTextPrefab, 2);
        }
        player.transform.position = teleportTarget.transform.position;

    }


    void ShowFloatingText()
    {
        Instantiate(FloatingTextPrefab, new Vector3(0.0f,0.0f,.0f), Quaternion.identity, Camera.transform);
    }
}
