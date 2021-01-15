using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteManager : MonoBehaviour
{
    public GameObject _noteImage;
    //bool activeImage;

    // Start is called before the first frame update
    void Start()
    {
         _noteImage.SetActive(false);
    }

    public void openImage()
    {
        _noteImage.SetActive(true);
        Cursor.visible = true;
        //store the image in array here before delete
        // activeImage = false;
    }

    public void closeImage()
    {
        _noteImage.SetActive(false);
        Cursor.visible = false;
    }
}
