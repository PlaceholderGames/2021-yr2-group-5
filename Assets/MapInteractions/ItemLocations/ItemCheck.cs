using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheck : MonoBehaviour
{
    bool CorrectItem;
    int LocationNumber;
    public SenteceCheck _Sen;

    void Start()
    {
        CorrectItem = false;
        if (gameObject.name.Contains((1).ToString()))
        {
            LocationNumber = 1;
        }
        else if (gameObject.name.Contains((2).ToString()))
        {
            LocationNumber = 2;
        }
        else if (gameObject.name.Contains((3).ToString()))
        {
            LocationNumber = 3;
        }
        //if (gameObject.name.Contains((4).ToString()))
        //{
        //    LocationNumber = 4;
        //}
    }
    private void OnTriggerEnter(Collider collision)
    {
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
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        CorrectItem = false;
    }

    public bool getItem()
    {
        print(CorrectItem);
        return CorrectItem;
    }

    public int getLocNum()
    {
        return LocationNumber;
    }
}
