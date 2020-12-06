using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TrapDoor : MonoBehaviour
{
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { anim.SetBool("TDOpen", true); }
        Debug.Log("Enters");
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") { anim.SetBool("TDOpen", false); }
        Debug.Log("Exits");
    }
}
