using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;
    public bool toggle;
    
    void Start ()
    {
        flashlight.enabled = false;
        toggle = false;
    }

    public void Toggle()
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
