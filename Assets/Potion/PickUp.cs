using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject _Text;
    PlayerManager manager;
    //private PotionTextScript Pscript;
    private void OnTriggerEnter(Collider collision)
    {   
        _Text.SetActive(true);   
    }

    void OnCollisionStay(Collision collision)
    {
        print("stuff");
        if (Input.GetKeyDown("f"))
        {
            print("fuck");
            manager.PickupItem();
            Destroy(gameObject);
        }
    }
}
