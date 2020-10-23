using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        if (manager)
        {
            if (manager.HavePotion == false)
            { 
                manager.PickupItem();
                Destroy(gameObject);
            }
        }
    }
}
