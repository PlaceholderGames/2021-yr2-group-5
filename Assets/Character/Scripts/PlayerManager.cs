using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public PotionManager _Potion;
    public PlaceObjects _Obj;
    public Flashlight _Flash;

    void Update()
    {
        if ((Input.GetKey("e")) && (_Potion.getHavePotion() == true))
        {
            _Potion.UsePotion();
        }

        else if ((Input.GetKey("z")) && (_Obj.getHaveItem() == true))
        {
            _Obj.PlaceRune();
        }

        else if (Input.GetKeyDown("q"))
        {
            _Flash.Toggle();
        }


    }
}
