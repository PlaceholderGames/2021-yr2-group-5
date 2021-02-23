using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{

    public Transform cameraTransform;
    public Transform heldObjSpot;
    public GameObject altar;
    RaycastHit hitInfo;
    public GameObject heldObject;
    public sanityscript sS;

    // Start is called before the first frame update
    void Start()
    {
        sS = GetComponent<sanityscript>();
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("PickUp/Drop"))
        {
            Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hitInfo, 7.5f);
            if (heldObject == null)
            {
                
                if (hitInfo.transform.gameObject.tag == "Rune")
                {
                    heldObject = Instantiate(hitInfo.transform.gameObject, Vector3.zero, Quaternion.identity, heldObjSpot);
                    Destroy(hitInfo.transform.gameObject);
                }
                //other casts
            }
            else if (heldObject != null)
            {
                if (hitInfo.transform.gameObject.tag == "Altar")
                {
                    altar.GetComponent<AltarScript>().PlaceObject(heldObject);
                    Destroy(heldObject);

                }
                else
                {
                    //Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hitInfo, 100.0f);
                    Instantiate(heldObject, new Vector3(hitInfo.point.x, hitInfo.point.y+0.5f, hitInfo.point.z), Quaternion.identity);
                    Destroy(heldObject);
                    heldObject = null;
                }
                
            }
            if (hitInfo.transform.gameObject.tag == "Drugs")
            {
                sS.Medicate();
                Destroy(hitInfo.transform.gameObject);
            }

        }
    }
}
