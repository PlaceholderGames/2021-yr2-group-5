using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Options options;

    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        options = FindObjectOfType<Options>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        float mouseY = Input.GetAxis("Mouse Y") * options.mouseSensitivity * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * options.mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
    }
}
