using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Light flick;
    private float checkTimer = 0.25f;
    private float currentTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        flick.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;
        int temp = Random.Range(1, 4);
        if (currentTimer > checkTimer)
        {
            if (temp == 1)
            {
                flick.enabled = true; //25% chance of getting the flicker light, making it unpredictable and randomized
            }
            else
            {
                flick.enabled = false;
            }
            currentTimer = 0f;
        }
    }
}
