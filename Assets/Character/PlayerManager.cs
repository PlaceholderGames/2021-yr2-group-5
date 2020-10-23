using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public bool HavePotion = false;

    //public int Potion;
    public int numOfPotion=0;
    public Image[] potions;
    public Sprite potionImage;

    public void PickupItem()
    {
        HavePotion = true;
        numOfPotion++;
    }

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
        
    }
}
