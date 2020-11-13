using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public bool HavePotion = false;

    public int numOfPotion=0;
    public Image[] potions;
    public Sprite potionImage;
    public BarCode _Bar;
    public Flashlight _Flash;

    void Start()
    {
        potions[0].enabled = false;
    }
    void Update()
    {
        if ((Input.GetKey("e")) && (HavePotion == true))
        {
            UsePotion();
        }
        else if (Input.GetKeyDown("q"))
        {
            _Flash.Toggle();
        }
    }

    public void PickupItem()
    {
        HavePotion = true;
        numOfPotion++;
        potions[0].enabled = true;
    }

    void UsePotion()
    {
        if (_Bar.timeLeft >= 100) { _Bar.timeLeft -= 100; }
        else { _Bar.timeLeft = 0; }
        HavePotion = false;
        numOfPotion--;
        potions[0].enabled = false;
    }
}
