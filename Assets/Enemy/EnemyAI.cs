using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent navMesh;
    CharacterMovement _char;
    bool reachedChar = false;
    float distanceStop = 5.0f;
    float distanceDestroy = 12.0f;
    BarCode bC;
    public Transform spawnLoc;

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        _char = FindObjectOfType<CharacterMovement>();
        bC = FindObjectOfType<BarCode>();
    }

    void Update()
    {



        float distance = Vector3.Distance(transform.position, _char.position);
        if (distance > distanceStop)
        {

            if (reachedChar == true && distance > distanceDestroy)
            {
                print(distance);
                Destroy(gameObject);
            }
            else
            {
                Vector3 dirToPlayer = transform.position - _char.position;

                Vector3 newPos = transform.position - dirToPlayer;

                navMesh.SetDestination(newPos);
            }
        }
        
        
    }
}
