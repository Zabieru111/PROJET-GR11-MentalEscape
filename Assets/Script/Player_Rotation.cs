using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotation : MonoBehaviour
{
    
    
    public float sensitivity = 100f;
    public Transform player;
    float xRotation = 0f;
    public 
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * x);

        

    }
   
}