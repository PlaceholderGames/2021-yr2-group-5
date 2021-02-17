using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traintrigger : MonoBehaviour
{

    public GameObject train;
    // Start is called before the first frame update
    void Start()
    {
        train.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            train.SetActive(true);
        }
    }
}
