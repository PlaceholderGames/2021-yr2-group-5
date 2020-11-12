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

    void Start()
    {
        potions[0].enabled = false;
    }
    void Update()
    {

        //for (int i = 0; i < potions.Length; i++)
        //{
        //    if (i < numOfPotion)
        //    {
        //        potions[i].enabled = true;
        //    }
        //    else
        //    {
        //        potions[i].enabled = false;
        //    }
        //}

        if ((Input.GetKey("e")) && (HavePotion == true))
        {
            UsePotion();
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
