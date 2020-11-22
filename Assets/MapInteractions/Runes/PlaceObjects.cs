using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : MonoBehaviour
{
    public GameObject ItemPrefab;
    public bool HaveItem = false;
    //public PlayerManager _Player;
    //public MousePosition _MousePos;
    public Vector3 worldPosition;
    private float waitTime = 0f;
    private float maxWait = 0.5f;

    void Update()
    {
        MousePosition();

        waitTime += Time.deltaTime;

        if (Input.GetKey("z")&&(waitTime>maxWait))
        {
            Instantiate(ItemPrefab, worldPosition, Quaternion.identity);
            waitTime = 0f;
            print("in the if");
        }
        print("out of if ");
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
}
