using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timeBetweenSpawns = 2f;
    private float timeSpawns;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
        timeSpawns -= Time.deltaTime;
        if (timeSpawns < 0)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            timeSpawns = timeBetweenSpawns;
        }
    }
}
