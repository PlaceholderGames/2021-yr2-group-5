using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DemonAI : MonoBehaviour
{

    private NavMeshAgent navMesh;
    public GameObject _char;
    public GameObject model;
    bool reachedChar = false;
    //BarCode bC;
    bool turn = false;
    bool spawned = true;
    RaycastHit hit;
    Vector3 rayDirection;
    float timeUnseen = 0;
    float time = 110;
    Vector3 checkPosition;
    public Transform spawnLoc;
    Vector3 dirToTarget;

    AudioSource aS;
    public AudioClip[] audioClips;
    float audioTime;
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        aS = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (audioTime < 0)
        {
            aS.pitch = Random.Range(0.8f, 1.2f);
            aS.Play();
            audioTime = Random.Range(2, 4);
        }
        audioTime -= Time.deltaTime;


        rayDirection = _char.transform.position - transform.position;
        if(spawned)
        {
            if (Physics.Raycast(transform.position, rayDirection, out hit))
            {
                if (hit.transform.gameObject.tag == "Player" && hit.distance <= 25f)
                {
                    Debug.Log("can see the player");
                    dirToTarget = transform.position - _char.transform.position;
                    aS.clip = audioClips[1];
                }
                else
                {
                    Debug.Log("cant see the player");
                    timeUnseen += Time.deltaTime;
                    aS.clip = audioClips[0];
                    if (timeUnseen >= 10)
                    {
                        dirToTarget = transform.position - new Vector3(Random.Range(-60f, 60f), 0, Random.Range(-60f, 60f));
                        timeUnseen = 0;
                    }
                }
                Vector3 newPos = transform.position - dirToTarget;
                navMesh.SetDestination(newPos);
            }
        }
        
    }
}
