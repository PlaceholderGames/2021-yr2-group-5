using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteManager : MonoBehaviour
{
    public GameObject _noteImage;
    //public CharacterMovement _mov;
    //public MouseLook _look;
   // var _moveScript;

    // Start is called before the first frame update
    void Start()
    {
        _noteImage.SetActive(false);
    }

    public void openImage()
    {
       // var _moveScript = gameObject.GetComponent(CharacterMovement);
        _noteImage.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //_moveScript.enabled = false;

        print("open");
        //store the image in array here before delete

    }

    public void closeImage()
    {
        _noteImage.SetActive(false);
        print("false");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
