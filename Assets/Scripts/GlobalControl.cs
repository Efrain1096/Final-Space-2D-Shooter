using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance { get; private set; }

    public float suiciderMoveSpeed = 2.0f;
    public float shooterFireRate = 1.5f;
    public int totalEnemyKills = 0;
    public int enemyOneSpawnCount = 10;
    public int enemyTwoSpawnCount = 5;
    public int enemyThreeSpawnCount = 0;



    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
