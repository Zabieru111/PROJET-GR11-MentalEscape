using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.8f;

    public Transform ground;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    //déplace le joueur en fonction de la touche peser
    //si le joueur tombe d'une surface augmente la vélocité
    //met la vélocité a 0 dès que le joueur touceh le sol
    void Update()
    {
        if (GameManager.instance.gameState == GameManager.state.inGame&&GameManager.instance.usingSomething==false)
        {
            isGrounded = Physics.CheckSphere(ground.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
           
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 movement = transform.right * x + transform.forward * z;

            controller.Move(movement * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }
}
