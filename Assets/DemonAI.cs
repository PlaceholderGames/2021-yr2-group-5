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
    BarCode bC;
    bool turn = false;
    bool spawned = false;
    RaycastHit hit;
    Vector3 rayDirection;
    float timeUnseen = 0;
    float time = 110;
    Vector3 checkPosition;
    public Transform spawnLoc;
    Vector3 dirToPlayer;

    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        bC = FindObjectOfType<BarCode>();
        //StartCoroutine(wait());
    }

    //IEnumerator wait()
    //{
    //    turn = false;
    //    yield return new WaitForSeconds(30);
    //    Debug.Log("chasing now");
        //while(turn == false)
        //{
        //    checkPosition = new Vector3(_char.transform.position.x+Random.Range(1, 5), _char.transform.position.y, _char.transform.position.z + Random.Range(1, 5));
        //    if(Physics.Raycast(checkPosition, _char.transform.position - checkPosition, out hit))
        //    {
        //        Debug.Log("spawning");
        //        turn = true;
        //        transform.position = checkPosition;
        //    }
            
            
        //}
        

        
    //}

    // Update is called once per frame
    void Update()
    {
        rayDirection = _char.transform.position - transform.position;
        if(spawned)
        {
            if (Physics.Raycast(transform.position, rayDirection, out hit))
            {
                if (hit.transform.gameObject.tag == "Player")
                {
                    Debug.Log("can see the player");
                    dirToPlayer = transform.position - _char.transform.position;
                }
                else
                {
                    Debug.Log("cant see the player");
                    timeUnseen += Time.deltaTime;
                    if (timeUnseen >= 15)
                    {
                        Debug.Log("ouch");
                        spawned = false;
                        model.SetActive(false);
                        timeUnseen = 0;
                    }
                }
                Vector3 newPos = transform.position - dirToPlayer;
                navMesh.SetDestination(newPos);
            }
        }
        else
        {
            time += Time.deltaTime;
            if(time >= 120)
            {
                model.SetActive(true);
                transform.position = spawnLoc.position;
                time = Random.Range(0.0f, 60.0f);
                spawned = true;
            }
        }
        //if (turn)
        //{
        //    Vector3 dirToPlayer = transform.position - _char.transform.position;
        //    Vector3 newPos = transform.position - dirToPlayer;
        //    navMesh.SetDestination(newPos);     
        //}
        //if (Physics.Raycast(transform.position, rayDirection, out hit))
        //{
        //    if (hit.transform.gameObject.tag == "Player")
        //    {
        //        Debug.Log("can see the player");
        //    }
        //    else
        //    {
        //        Debug.Log("cant see the player");
        //        timeUnseen += Time.deltaTime;
        //        if(timeUnseen >= 3)
        //        {
        //            Debug.Log("ouch");
        //            turn = false;
        //            transform.position = new Vector3(0, -10, 0);
        //            timeUnseen = 0;
        //        }
        //    }
        //}
    }
}
