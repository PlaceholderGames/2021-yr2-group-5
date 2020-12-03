using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PotionManager : MonoBehaviour
{
    public BarCode _Bar;
    bool HavePotion = false;
    int numOfPotion = 0;
    public Image[] potions;
    public Sprite potionImage;

    // Start is called before the first frame update
    void Start()
    {
        potions[0].enabled = false;
    }

    public void UsePotion()
    {
        if (_Bar.getTimeLeft() >= 100)
        {
            _Bar.setTimeLeft((_Bar.getTimeLeft()-100));
        }
        else
        {
            _Bar.setTimeLeft(0);
        }

        HavePotion = false;
        numOfPotion--;
        potions[0].enabled = false;
    }

    public void PickupItem()
    {
        HavePotion = true;
        numOfPotion++;
        potions[0].enabled = true;
    }

    public bool getHavePotion()
    {
        return HavePotion;
    }

    public int getNumOfPos()
    {
        return numOfPotion;
    }
}
