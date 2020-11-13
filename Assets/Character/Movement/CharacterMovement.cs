using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    Flashlight _flash;
    public float walkSpeed = 10f;
    public float sprintSpeed = 15f;
    public float crouchSpeed = 5f;
    public Vector3 position; 

    // Update is called once per frame
    void Update()
    {
        float currentSpeed;  
        float x = Input.GetAxis("Horizontal"); 
        float z = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.LeftShift) && z > 0)
        {
            if(controller.height < 3.8)
            {
                controller.height += 0.1f;
            }
            currentSpeed = sprintSpeed;
            
        } // Check if sprinting
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            currentSpeed = crouchSpeed;
            controller.height = 2f;
        } //Check if crouching
        else 
        {
            if (controller.height < 3.8)
            {
                controller.height+=0.1f;
            }
            currentSpeed = walkSpeed;
            
        } //If walking

        Vector3 move = transform.right * x + transform.forward * z + transform.up*-1;
        controller.Move(move * currentSpeed * Time.deltaTime);
        position = transform.position;

    }


}