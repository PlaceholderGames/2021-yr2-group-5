using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject _Text;

    private void OnTriggerEnter(Collider collision)
    {
        _Text.SetActive(true);
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey("f"))
            {
                if (gameObject.tag == "Consumable")
                {
                    PotionManager manager = collision.GetComponent<PotionManager>();
                    if ((manager.getHavePotion() == false))
                    {
                        manager.PickupItem();
                        Destroy(gameObject);
                        _Text.SetActive(false);
                    }
                }

                else if (gameObject.tag == "Rune")
                {
                    PlaceObjects manager = collision.GetComponent<PlaceObjects>();
                    if (manager.getHaveItem() == false)
                    {
                        manager.PickRune(gameObject.name);
                        Destroy(gameObject);
                        _Text.SetActive(false);
                    }
                }

                else if (gameObject.tag == "Flashlight")
                {
                    getTorch manager = collision.GetComponent<getTorch>();
                    if (manager.getHaveTorch() == false)
                    {
                        manager.pickUpTorch();
                        Destroy(gameObject);
                        _Text.SetActive(false);
                    }
                }

                else if (gameObject.tag == "Notes")
                {
                    noteManager manager = collision.GetComponent<noteManager>();
                    manager.pickUpNote();
                    Destroy(gameObject);
                    _Text.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        _Text.SetActive(false);
    }
}
