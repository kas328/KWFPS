using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    [SerializeField] GameObject[] enemys;
    [SerializeField] Transform[] spawnPoints;

    [SerializeField] float SpawnDelay;
    [SerializeField] float curSpawnDelay;
    void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if (curSpawnDelay > SpawnDelay)
        {
            SpawnEnemy();
            curSpawnDelay = 0;
        }
    }
    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, enemys.Length);
        int ranPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemys[ranEnemy], spawnPoints[ranPoint].position, Quaternion.identity);
    }
}
