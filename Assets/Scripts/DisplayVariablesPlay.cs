using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayVariablesPlay : MonoBehaviour
{
    public SpawnEnemies spawnScript;
    public GameObject spawnObject;
    public Text totalEnemyKills;
    public Text wavesSurvived;

    // Start is called before the first frame update
    void Start()
    {
        spawnScript = spawnObject.GetComponent<SpawnEnemies>();
        spawnScript.totalEnemyKills = GlobalControl.Instance.totalEnemyKills;
    }

    // Update is called once per frame
    void Update()
    {
        GlobalControl.Instance.totalEnemyKills = spawnScript.totalEnemyKills;
        totalEnemyKills.text = "Enemies Killed: " + spawnScript.totalEnemyKills;


    }

    
}
