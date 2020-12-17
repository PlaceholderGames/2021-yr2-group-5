using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOn : MonoBehaviour
{
    bool powerOn = false;
    public Light[] lights;
    public GameObject _PowerText;
   
    void Start ()
    {
        foreach (Light lamp in lights)
        {
            lamp.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (powerOn == false) { _PowerText.SetActive(true); }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (Input.GetKey("f") && powerOn == false)
        {
            foreach(Light lamp in lights)
            {
                lamp.enabled = true;
                print("Lamp Enabled");
            }
            powerOn = true;
        }


    }

    private void OnTriggerExit(Collider collision)
    {
        _PowerText.SetActive(false);
    }

   
}
