using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject _text;
    public Light flashlight;
    public bool toggle=false;
    public bool haveFlash=false;
    public bool initial;
    void Start ()
    {
        initial = true;
        flashlight.enabled = false;
        _text.SetActive(true);
    }

    public void setHaveFlash()
    {
        haveFlash = true;
    }

    public void Toggle()
    {
        if (haveFlash == true)
        {
            if (toggle == false)
            {
                if (initial)
                {
                    _text.SetActive(false);
                    initial = false;
                }
                flashlight.enabled = true;
                toggle = true;
            }
            else
            {
                flashlight.enabled = false;
                toggle = false;
            }
        }
    }
}
