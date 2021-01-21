using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{

    Transform cameraTransform;
    public Transform heldObjSpot;
    RaycastHit hitInfo;
    public GameObject heldObject;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("PickUp/Drop"))
        {
            if(heldObject == null)
            {
                Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hitInfo, 100.0f);
                if (hitInfo.transform.gameObject.tag == "Rune")
                {
                    heldObject = Instantiate(hitInfo.transform.gameObject, Vector3.zero, Quaternion.identity, heldObjSpot);
                    Destroy(hitInfo.transform.gameObject);
                }
                //other casts
            }
            else if (heldObject != null)
            {
                Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hitInfo, 100.0f);
                Instantiate(heldObject, hitInfo.point, Quaternion.identity);
                Destroy(heldObject);
                heldObject = null;
            }

        }
    }
}
