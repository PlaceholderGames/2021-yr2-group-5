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
            if (gameObject.tag == "Consumable")
            {
                PotionManager manager = collision.GetComponent<PotionManager>();
                if ((manager.getHavePotion() == false) && (Input.GetKey("f")))
                {
                    manager.PickupItem();
                    Destroy(gameObject);
                    _Text.SetActive(false);
                }
            }

            else if (gameObject.tag == "Rune")
            {
                PlaceObjects manager = collision.GetComponent<PlaceObjects>();
                if (manager.getHaveItem() == false && Input.GetKey("f"))
                {
                    manager.PickRune(gameObject.name);
                    Destroy(gameObject);
                    _Text.SetActive(false);
                }
            }

            else if (gameObject.tag == "Flashlight")
            {
                getTorch manager = collision.GetComponent<getTorch>();
                if (manager.getHaveTorch() == false && Input.GetKey("f"))
                {
                    manager.pickUpTorch();
                    Destroy(gameObject);
                    _Text.SetActive(false);
                }
            }

            else if (gameObject.tag == "Notes")
            {
                if (Input.GetKey("f"))
                {
                    noteManager manager = collision.GetComponent<noteManager>();
                    manager.openImage();
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
