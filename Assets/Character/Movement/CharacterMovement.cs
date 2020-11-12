using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public float walkSpeed = 10f;
    public float sprintSpeed = 15f;
    public Vector3 position;

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = walkSpeed;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.LeftShift) && z > 0)
        {
            currentSpeed = sprintSpeed;
        }

        Vector3 move = transform.right * x + transform.forward * z + transform.up*-1;
        controller.Move(move * currentSpeed * Time.deltaTime);
        position = transform.position;

    }


}