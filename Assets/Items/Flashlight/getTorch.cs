using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTorch : MonoBehaviour
{
    bool HaveTorch;

    public Flashlight _Light;
    public GameObject _Flashlight;
    // Start is called before the first frame update
    void Start()
    {
        HaveTorch = false;
        _Flashlight.SetActive(false);
    }

    public bool getHaveTorch()
    {
        return HaveTorch;
    }

    public void pickUpTorch()
    {
        HaveTorch = true;
        _Flashlight.SetActive(true);
        _Light.setHaveFlash();
    }
}

