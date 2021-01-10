using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public Vector3 worldPosition;

    void Update()
    {
        ////youtube
        //Plane plane = new Plane(Vector3.up, 0);

        //float distance;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (plane.Raycast(ray, out distance))
        //{
        //    worldPosition = ray.GetPoint(distance);
        //}

        ////khalid 
        //RaycastHit hit;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (Physics.Raycast(ray, out hit))
        //{
        //    // if (hit.transform.gameObject.tag == "Ground")
        //    worldPosition = hit.point;
        //}
    }
}
