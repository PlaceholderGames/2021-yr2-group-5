using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheck : MonoBehaviour
{
    bool CorrectItem = false;
    int LocationNumber;
    public SenteceCheck _Sen;

    void Start()
    {
        if (gameObject.name.Contains((1).ToString()))
        {
            LocationNumber = 1;
        }
        if (gameObject.name.Contains((2).ToString()))
        {
            LocationNumber = 2;
        }
        if (gameObject.name.Contains((3).ToString()))
        {
            LocationNumber = 3;
        }
        //if (gameObject.name.Contains((4).ToString()))
        //{
        //    LocationNumber = 4;
        //}
    }

    private void OnTriggerStay(Collider collision)
    {
        print(collision.tag);
        if (collision.tag == "Rune")
        {
            if (collision.name.Contains(LocationNumber.ToString()))
            {
                CorrectItem = true;
                _Sen.Check();

            }
            else
            {
                CorrectItem = false;
            }
            print(CorrectItem);
        }
    }

    public bool getItem()
    {
        return CorrectItem;
    }

    public int getLocNum()
    {
        return LocationNumber;
    }
}
