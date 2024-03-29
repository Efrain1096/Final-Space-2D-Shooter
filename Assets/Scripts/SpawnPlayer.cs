using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    //Doesn't work, may not end up using.
    public GameObject player;

    Vector2 whereToSpawn;
    public bool playerDestroyed = false;
    public int playerLives = 3;
    
    private void Start()
    {
            whereToSpawn = new Vector2(-7.0f, 0.0f);
            Instantiate(player, whereToSpawn, Quaternion.identity);        
    }

    private void Update()
    {

        if(playerDestroyed)
        {
            whereToSpawn = new Vector2(-7.0f, 0.0f);
            Instantiate(player, whereToSpawn, Quaternion.identity);
            playerDestroyed = false;
        }
    }
}
