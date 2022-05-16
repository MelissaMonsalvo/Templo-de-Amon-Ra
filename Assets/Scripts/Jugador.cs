using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
public CharacterController cc;
    public float Velocidad=12;
    public float rotationSpeed = 180;
    public float Gravedad = -9.81f;
    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask floorMask;
    bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, floorMask);
        
        if (isGrounded && velocity.y<0)
        {
            velocity.y = -3f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(3 * -2f * Gravedad);
        }

        float x = 0; //Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");

        Vector3 move = transform.right * x+transform.forward*z;
        cc.Move(move*Velocidad*Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal")*rotationSpeed,0);


        velocity.y += Gravedad * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
        

    }

}
