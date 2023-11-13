using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMove : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 moveVector = Vector3.zero;
    CharacterController characterController;
    public float jumpSpeed;
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * -5;
        float v = Input.GetAxis("Vertical") * 5;

        Vector3 vel = rb.velocity;
        vel.x = v;
        vel.z = h;
        rb.velocity = vel;
        }
    void Update() 
    { 
        if (characterController.isGrounded && Input.GetKeyDown("Space"))
        {
            moveVector.y = jumpSpeed;

            moveVector.y -= gravity * Time.deltaTime;

            characterController.Move(moveVector * Time.deltaTime);
        }
    }
}
