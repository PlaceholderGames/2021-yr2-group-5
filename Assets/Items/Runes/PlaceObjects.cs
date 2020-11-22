using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : MonoBehaviour
{
    public GameObject ItemPrefab;
    public bool HaveItem = true;
    public Vector3 worldPosition;


    void Update()
    {
        MousePosition();
    }

    void MousePosition()
    {
        Plane plane = new Plane(Vector3.up, 0);

        float distance;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        }
    }

    public void PlaceRune()
    {
        Instantiate(ItemPrefab, worldPosition, Quaternion.identity);
        HaveItem = false;
    }

    public void GetRune()
    {
        HaveItem = true;
    }
}

