using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public Light flashlight;
    public bool toggle=false;
    public bool haveFlash=false;
    
    void Start ()
    {
        flashlight.enabled = false;
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
