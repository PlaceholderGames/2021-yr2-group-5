using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class sanityscript : MonoBehaviour
{
    public float sanity = 100;
    public Volume v;
    public Vignette vG;
    public ChromaticAberration cA;
    // Start is called before the first frame update
    void Start()
    {
        //v = GetComponent<Volume>();
        v.profile.TryGet(out vG);
        v.profile.TryGet(out cA);
    }

    // Update is called once per frame
    void Update()
    {
        sanity -= Time.deltaTime/2;
        vG.intensity.value = 1 - (sanity / 100);
        cA.intensity.value -= Time.deltaTime / 200;
        if(sanity < 0)
        {
            Die();
        }
    }
    public void Medicate()
    {
        sanity = 100;
        cA.intensity.value += 0.2f;
    }
    void Die()
    {
        Debug.Log("player has died");
        transform.position = new Vector3(0, 7.5f, 0);
        sanity = 100;
        cA.intensity.value = 0;
    }
}
