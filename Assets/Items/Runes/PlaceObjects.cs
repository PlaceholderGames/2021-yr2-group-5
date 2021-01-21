using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : MonoBehaviour
{
    public GameObject _text;
    public bool HaveItem = false;
    Vector3 worldPosition;
    string RuneName=null;
    float dis = 10;
    bool initial = true;
    GameObject[] ItemPrefab;
  

    void MousePosition() 
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            // if (hit.transform.gameObject.tag == "Ground")
            worldPosition = hit.point;
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
        //worldPosition.y += ItemPrefab[i].GetComponent<MeshFilter>().sharedMesh.bounds.extents.y * 2;
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
            worldPosition.y += ItemPrefab[i].GetComponent<MeshFilter>().sharedMesh.bounds.extents.y;
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

