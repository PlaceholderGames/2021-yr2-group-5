using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar : MonoBehaviour
{
    int runes = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(runes >= 3)
        {
            Debug.Log("you win");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rune")
        {
            runes++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Rune")
        {
            runes--;
        }
    }
}
