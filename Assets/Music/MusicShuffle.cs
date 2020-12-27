using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicShuffle : MonoBehaviour
{
    public AudioSource Music1;
    public AudioSource Music2;
    public AudioSource Music3;

    // Start is called before the first frame update
    void Start()
    {
        //Music1 = gameObject.AddComponent<AudioSource>();
        //Music2 = gameObject.AddComponent<AudioSource>();
        //Music3 = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!Music1.isPlaying && !Music2.isPlaying && !Music3.isPlaying)
        {
            
            int num = Random.Range(1, 4);
            
            switch (num)
            {
                case 1:
                    print(num);
                    Music1.Play();
                    break;
                case 2:
                    print(num);
                    Music2.Play();
                    break;
                case 3:
                    print(num);
                    Music3.Play();
                    break;
                case 4:
                    print(num);
                    break;
            }
                    
        }
            
    }
}
