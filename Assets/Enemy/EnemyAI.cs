using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent demon;
    CharacterMovement _char;
    bool reachedChar = false;
    float distanceStop = 5.0f;
    float distanceDestroy = 12.0f;
    BarCode bC;

    void Start()
    {
        demon = GetComponent<NavMeshAgent>();
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

                demon.SetDestination(newPos);
            }
        }
        if (Physics.Linecast(transform.position, _char.position, 8))
        {
                //anything here is called if there's something between the demon and player
                //it means the player can't be haunted whilst in a hiding place
        }
        else if(distance < distanceStop)
        {
            demon.SetDestination(transform.position);
            //play scary noise code goes here 
            bC.timeLeft += Time.deltaTime;
            reachedChar = true;
        }
        
    }
}
