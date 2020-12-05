using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : MonoBehaviour
{
    public GameObject[] ItemPrefab;
    bool HaveItem = false;
    Vector3 worldPosition;
    string RuneName=null;
    float dis = 4;
  
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
        print(worldPosition);         
            
    }

    public void PlaceRune()
    {
        float spawnDistance = Vector3.Distance(transform.position, worldPosition);
        if (spawnDistance < dis)
        {
            int i = 0;
            bool j = true;

            while (j == true)
            {
                if (RuneName.Contains((i + 1).ToString()))
                {
                    j = false;
                }
                else i++;
                if (i > ItemPrefab.Length)
                {
                    j = false;
                    print("out of array range ");
                }
            }
            Instantiate(ItemPrefab[i], worldPosition, Quaternion.identity);
            HaveItem = false;
        }
        else { print("out of range"); }
    }

    public void PickRune(string _name)
    {
        HaveItem = true;
        RuneName = _name;        
    }

    public bool getHaveItem()
    {
        return HaveItem;
    }
}

