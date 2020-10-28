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
    
    bool UseItem = Input.GetButton("Use");

    void Update()
    {
        for (int i = 0; i < potions.Length; i++)
        {
            if (i < numOfPotion)
            {
                potions[i].enabled = true;
            }
            else
            {
                potions[i].enabled = false;
            }
        }
        UseItem = Input.GetButton("Use");
        //bool x = Input.GetAxis("Use");
        if ( (UseItem==true) && (HavePotion == true))
        {
            UsePotion();
        }


    }

    public void PickupItem()
    {
        HavePotion = true;
        numOfPotion++;
    }

    void UsePotion()
    {
        if (_Bar.timeLeft >= 100) { _Bar.timeLeft -= 100; }
        else { _Bar.timeLeft = 0; }
        HavePotion = false;
        numOfPotion--;
    }
}
