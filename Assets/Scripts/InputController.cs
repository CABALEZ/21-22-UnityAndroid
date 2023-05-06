using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    Transform cam;
    public Joystick joystickMove;
    public Joystick joystickRotate;
    public Rigidbody rb;
    float rotateV;
    float rotateH;
    public float speed = 10.0f;
    public float speedGiro = 0.2f;
    private Animator anim;
    

    private void Start()
    {
        cam = Camera.main.transform;
        anim = GetComponent<Animator>();

    }

    public void Jump()
    {
        rb.velocity += Vector3.up * speed; 
    }

    void Rotate()
    {
        rotateH = joystickRotate.Horizontal * speedGiro;
        rotateV = -(joystickRotate.Vertical * speedGiro);
        cam.Rotate(rotateV,rotateH,0);
    }

    void Move()
    {
        rb.velocity = new Vector3(joystickMove.Horizontal * speed + Input.GetAxis("Horizontal"),
            rb.velocity.y,joystickMove.Vertical *speed + Input.GetAxis("Vertical"));
    }

    private void Update()
    {
        Move();
        Rotate();
        anim.SetFloat("VelX", joystickMove.Horizontal);
        anim.SetFloat("VelY", joystickMove.Vertical);
    }


}
