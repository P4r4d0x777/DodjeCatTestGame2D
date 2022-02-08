using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject _enemy;

    public float _xPositionLimit;

    public float spawnRate;

    private void Start()
    {
        StartSpawning();
    }

    void SpawnSpike()
    {
        float randomX = Random.Range(-_xPositionLimit, _xPositionLimit);

        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(_enemy, spawnPosition, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnInvoke");
    }
}
