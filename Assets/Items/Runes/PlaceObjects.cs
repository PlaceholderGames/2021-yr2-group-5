using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : MonoBehaviour
{
    public GameObject _text;
    public GameObject[] ItemPrefab;
    public bool HaveItem = false;
    Vector3 worldPosition;
    string RuneName=null;
    float dis = 4;
    bool initial = true;
  

    void MousePosition() 
    {
        Plane plane = new Plane(Vector3.up, 0);

        float distance;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        }
        //print(worldPosition);
            
    }

    public void PlaceRune()
    {
        MousePosition();
        if (initial)
        {
            _text.SetActive(false);
            initial = false;
        }
    
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
            print("Object Spawned");
            HaveItem = false;
        }
        else { print("Couldnt spawn, you are pointing too far away"); }
    }

    public void PickRune(string _name)
    {
        if (initial)
        {
            _text.SetActive(true);
        }
        HaveItem = true;
        RuneName = _name;        
    }

    public bool getHaveItem()
    {
        return HaveItem;
    }
}

