using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    public float gravity;
    Options options;

    public CharacterController controller;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        options = FindObjectOfType<Options>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y -= gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);
    }
}
