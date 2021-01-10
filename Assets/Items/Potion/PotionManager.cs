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
    int potionsUsed = 0;
    public Image[] potions;
    public Sprite potionImage;
    public GameObject _text;
    float timer;
    

    // Start is called before the first frame update
    void Start()
    {
        potions[0].enabled = false;
        timer = 0.0f;
    }

    void Update()
    {
        
        if (timer > 0f)
        {
            timer+= Time.deltaTime;
            if (timer > 6.6f)
            {
                _text.SetActive(false);
            }
        }
       
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
        potionsUsed++;
        potions[0].enabled = false;
    }

    public void PickupItem()
    {
        if (timer==0)
        {
            _text.SetActive(true);
            timer += Time.deltaTime;
        }
        HavePotion = true;
        numOfPotion++;
        potions[0].enabled = true;
    }

    public int getPotionsUsed()
    {
        return potionsUsed;
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
