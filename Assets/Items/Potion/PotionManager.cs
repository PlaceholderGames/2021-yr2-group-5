using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PotionManager : MonoBehaviour
{
    public BarCode _Bar;
    public bool HavePotion = false;
    public int numOfPotion = 0;
    public Image[] potions;
    public Sprite potionImage;

    // Start is called before the first frame update
    void Start()
    {
        potions[0].enabled = false;
    }

    public void UsePotion()
    {
        print("use");
        if (_Bar.timeLeft >= 100)
        {
            _Bar.timeLeft -= 100;
        }
        else
        {
            _Bar.timeLeft = 0;
        }

        HavePotion = false;
        numOfPotion--;
        potions[0].enabled = false;
    }

    public void PickupItem()
    {
        print("picking up");
        HavePotion = true;
        numOfPotion++;
        potions[0].enabled = true;
    }
}
