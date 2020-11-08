using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent demon;
    public float demonDistanceRun = 10.0f;
    CharacterMovement _char;
    public float distanceDestoyed=2.0f;

    void Start()
    {
        demon = GetComponent<NavMeshAgent>();
        _char = FindObjectOfType<CharacterMovement>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, _char.position);
        
        if (distance<demonDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - _char.position;
            
            Vector3 newPos = transform.position - dirToPlayer;

            demon.SetDestination(newPos);
            if (distance < distanceDestoyed)
            {
                Destroy(gameObject);
            }
        }
    }
}
