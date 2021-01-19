using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteManager : MonoBehaviour
{
    public GameObject _noteImage;
    public MouseLook _look;
    bool haveNote = false;

    // Start is called before the first frame update
    void Start()
    {
        _noteImage.SetActive(false);
    }

    public void openImage()
    {
        // var _moveScript = gameObject.GetComponent(CharacterMovement);
        this.GetComponent<CharacterMovement>().enabled = false;
        _look.GetComponent<MouseLook>().enabled = false;
        _noteImage.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //store the image in array here before delete

    }

    public void closeImage()
    {
        this.GetComponent<CharacterMovement>().enabled = true;
        _look.GetComponent<MouseLook>().enabled = true;
        _noteImage.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void pickUpNote()
    {
        haveNote = true;
        openImage();
    }

    public bool getHaveNote()
    {
        return haveNote;
    }
}
