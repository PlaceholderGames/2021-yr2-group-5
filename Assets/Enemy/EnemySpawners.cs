using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class EnemySpawners : MonoBehaviour
{
    public Transform[] _SpawnPoints;
    public GameObject _DemonPrefab;
    public BarCode _bar;
    private bool spawning=true;

    void Start()
    {
        SpawnNewDemon();
    }

    void Update()
    {
        int num = (int)_bar.getTimeLeft();
        if ((num % 5) !=0)
        {
            spawning = true;
        }
        if (num % 5 == 0 && num != 0 && spawning == true)
        {
            SpawnNewDemon();
            spawning = false;
        }
    }

    void SpawnNewDemon()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, _SpawnPoints.Length - 1));
        
        Instantiate(_DemonPrefab, _SpawnPoints[randomNumber].transform.position, Quaternion.identity);
    }
}
