using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarScript : MonoBehaviour
{

    public Transform[] spots;
    public GameObject[] items;
    public Transform player;
    public GameObject Wall;
    public GameObject[] mazeDoors;
    public GameObject[] mazeWalls;

    string activeHint;
    string wantedItem;

    int score = 0;

    string[] RitualItems = { "alarmclock", "axe", "barrel", "book", "camera", "candle", "cassette", "coins", "frame", "glowstick", "grave", "mortar and pestle", "pencil", "phone", "pipe", "remote", "ring", "rod", "soap", "toothbrush" };
    string[] RitualHints = { "amser", "bwyell", "casgen", "darllen", "fflach", "tân", "cerddoriaeth", "aur", "celf", "ysgafn", "marw", "cymysgedd", "ysgrifennu", "ffôn", "ysmygu", "teledu", "gemwaith", "pysgod", "sebon", "dannedd" };

    // Start is called before the first frame update
    void Start()
    {
        NewItem();
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 3 && player.position.y >= 1f)
        {
            Wall.SetActive(false);
            score++;
            transform.localPosition = new Vector3(214.2f, -3.4f, -22.8f);
            for (int n = 0; n < 3; n++)
            {
                Destroy(items[n]);
                items[n] = null;
            }
        }
        if (score == 5 && player.position.y >= 1f)
        {
            Wall.SetActive(true);
            for(int n = 0; n < 3; n++)
            {
                mazeDoors[n].SetActive(false);
                mazeWalls[n].SetActive(true);
            }
            score++;
        }
        if(score == 7)
        {
            Debug.Log("you win!");
        }
    }
    public void PlaceObject(GameObject obj)
    {
        if(obj.name.Contains(wantedItem))
        {
            for(int n = 0; n < 3; n++)
            {
                if (items[n] == null)
                {
                    
                    GameObject newObj = Instantiate(obj, spots[n].position, Quaternion.identity, transform);
                    newObj.tag = null;
                    Destroy(newObj.GetComponentInChildren<Collider>());
                    Destroy(newObj.GetComponent<Rigidbody>());
                    items[n] = newObj;
                    break;
                }
            }
            score++;
            NewItem();
        }
        else
        {
            Instantiate(obj, new Vector3(0, 2, 0), Quaternion.identity);
        }
    }
    void NewItem()
    {
        int roll = Random.Range(0, 20);
        activeHint = RitualHints[roll];
        wantedItem = RitualItems[roll];
        Debug.Log(activeHint);
    }
}
