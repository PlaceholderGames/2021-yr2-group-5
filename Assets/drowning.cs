using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drowning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && other.transform.position.y < -1f)
        {
            other.gameObject.GetComponent<sanityscript>().sanity -= Time.deltaTime * 20;
            Debug.Log("drowning");
        }
    }
}
