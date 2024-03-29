using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    Vector2 whereToSpawn1;
    Vector2 whereToSpawn2;
    Vector2 whereToSpawn3;

    public int enemyCount = 0;
    public int enemyKillCount = 0;
    public int totalEnemyKills = 0;
    public int enemyOneSpawnCount = 10;
    public int enemyTwoSpawnCount = 5;
    public int enemyThreeSpawnCount = 0;
    public float randomYPoint;
    public float randomXPoint;

    private void Start()
    {
        for (int i = 0; i < enemyOneSpawnCount; i++)
        {
            randomYPoint = Random.Range(-4.5f, 4.5f);
            randomXPoint = Random.Range(9.0f, 13.0f);
            whereToSpawn1 = new Vector2(randomXPoint, randomYPoint);
            Instantiate(enemy1, whereToSpawn1, Quaternion.identity);
            enemyCount++;
        }

        for (int i = 0; i < enemyTwoSpawnCount; i++)
        {
            randomYPoint = Random.Range(-4.5f, 4.5f);
            randomXPoint = Random.Range(8.0f, 10.0f);
            whereToSpawn2 = new Vector2(randomXPoint, randomYPoint);
            Instantiate(enemy2, whereToSpawn2, Quaternion.identity);
            enemyCount++;
        }

        for (int i = 0; i < enemyThreeSpawnCount; i++)
        {
            randomYPoint = Random.Range(-4.5f, 4.5f);
            randomXPoint = Random.Range(8.0f, 10.0f);
            whereToSpawn3 = new Vector2(randomXPoint, randomYPoint);
            Instantiate(enemy3, whereToSpawn3, Quaternion.identity);
            enemyCount++;
        }

    }
    
   
}
