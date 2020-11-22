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
        if (gameObject.tag == "Consumable")
        {
            print(gameObject.tag);
            PotionManager manager = collision.GetComponent<PotionManager>();
            if ((manager.HavePotion == false) && (Input.GetKey("f")))
            {
                manager.PickupItem();
                Destroy(gameObject);
                _Text.SetActive(false);
            }
        }

        else if (gameObject.tag == "Rune")
        {
            print(gameObject.tag);
            PlaceObjects manager = collision.GetComponent<PlaceObjects>();
            if (manager.HaveItem == false && Input.GetKey("f"))
            {
                manager.GetRune();
                Destroy(gameObject);
                _Text.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        _Text.SetActive(false);
    }
}
