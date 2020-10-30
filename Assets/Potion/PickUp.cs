using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject _Text;
    
    //private PotionTextScript Pscript;
    private void OnTriggerEnter(Collider collision)
    {   
        _Text.SetActive(true);   
    }

    private void OnTriggerStay(Collider collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        print("oi");
        if ((manager.HavePotion == false) && (Input.GetKeyDown("f")))
        {
            manager.PickupItem();
            print("nai");
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerExit(Collider collision)
    {
        _Text.SetActive(false);
    }
}
