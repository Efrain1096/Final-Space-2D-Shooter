
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    //This script is solely for changing levels or scenes when a certain amount of enemies have been killed (Still work in  progress)

  //  private Enemy[] enemiesInScene;
    private static int levelIndex = 1;
    private Player[] playerInScene;
   
    public SpawnEnemies spawnScript; // Need to drag the object that holds the script
    public GameObject spawnObject; // Here as well
    
    public EnemySuiciderAI suiciderScript;
    public GameObject suiciderObject;

    public EnemyShooting shootingScript;
    public GameObject shooterObject;

    private void OnEnable()
    {
        suiciderScript = suiciderObject.GetComponent<EnemySuiciderAI>();
        spawnScript = spawnObject.GetComponent<SpawnEnemies>();
        shootingScript = shooterObject.GetComponent<EnemyShooting>();
        playerInScene = FindObjectsOfType<Player>();

        suiciderScript.suiciderMoveSpeed = GlobalControl.Instance.suiciderMoveSpeed;
        shootingScript.shooterFireRate = GlobalControl.Instance.shooterFireRate;
       
        spawnScript.enemyOneSpawnCount = GlobalControl.Instance.enemyOneSpawnCount;
        spawnScript.enemyTwoSpawnCount = GlobalControl.Instance.enemyTwoSpawnCount;
        spawnScript.enemyThreeSpawnCount = GlobalControl.Instance.enemyThreeSpawnCount;

    }

    // Update is called once per frame
    void Update()
    {
        OnEnable();// Contantly check if new enemies have been spawned before the next level can be loaded.
        CheckForPlayer();
        Debug.Log((spawnScript.enemyOneSpawnCount + spawnScript.enemyTwoSpawnCount + spawnScript.enemyThreeSpawnCount));
        if (levelIndex > 3) // Just cycle through the levels to provide a change of scenery for now.
        {

            suiciderScript.suiciderMoveSpeed += 0.1f;// Every level progression increases suicider ship speed.
            shootingScript.shooterFireRate -= 0.1f;
            spawnScript.enemyOneSpawnCount += 1;
            spawnScript.enemyTwoSpawnCount += 1;
            spawnScript.enemyThreeSpawnCount += 2;
            GlobalControl.Instance.enemyOneSpawnCount = spawnScript.enemyOneSpawnCount;
            GlobalControl.Instance.enemyTwoSpawnCount = spawnScript.enemyTwoSpawnCount;
            GlobalControl.Instance.enemyThreeSpawnCount = spawnScript.enemyThreeSpawnCount;

            GlobalControl.Instance.suiciderMoveSpeed = suiciderScript.suiciderMoveSpeed;
            GlobalControl.Instance.shooterFireRate = shootingScript.shooterFireRate;
           
            levelIndex = 1;
            string nextLevel = "Level" + levelIndex;
            StartCoroutine(WaitForNextLevel(nextLevel));



        }




        if ((spawnScript.enemyOneSpawnCount + spawnScript.enemyTwoSpawnCount + spawnScript.enemyThreeSpawnCount) == spawnScript.enemyKillCount) //When all spawned enemies are killed, load next level and increase their stats.
        {
            suiciderScript.suiciderMoveSpeed += 0.1f;// Every level progression increases suicider ship speed.
            shootingScript.shooterFireRate -= 0.1f; // And fire rate of the projectile shooting enemies.
           
            spawnScript.enemyOneSpawnCount += 1;
            spawnScript.enemyTwoSpawnCount += 1;
            spawnScript.enemyThreeSpawnCount += 2;

            GlobalControl.Instance.enemyOneSpawnCount = spawnScript.enemyOneSpawnCount;
            GlobalControl.Instance.enemyTwoSpawnCount = spawnScript.enemyTwoSpawnCount;
            GlobalControl.Instance.enemyThreeSpawnCount = spawnScript.enemyThreeSpawnCount;

            GlobalControl.Instance.suiciderMoveSpeed = suiciderScript.suiciderMoveSpeed;
            GlobalControl.Instance.shooterFireRate = shootingScript.shooterFireRate;

            levelIndex++;
            string nextLevel = "Level" + levelIndex;
            StartCoroutine(WaitForNextLevel(nextLevel));
        }



        //Once this point is reached, show score, high score, and then show a button to prompt for the user to proceed to the next
        //level when the user clicks/presses the button. Perhaps a rating system as well.
    }

    private void CheckForPlayer()
    {
        foreach (Player player in playerInScene)
        {
            if (player != null)//If an enemy isn't null, which means dead or destroyed
            {
                return;
            }
        }
        //Reset enemy stats and global score once player dies.
        GlobalControl.Instance.enemyOneSpawnCount = 5;
        GlobalControl.Instance.enemyTwoSpawnCount = 5;
        GlobalControl.Instance.enemyThreeSpawnCount = 0;
        GlobalControl.Instance.suiciderMoveSpeed = 2.0f;
        GlobalControl.Instance.shooterFireRate = 1.0f;
        StartCoroutine(WaitToLoadScoreScreen()); // Wait a little bit for the transitioning of scenes
        levelIndex = 1;
    }

    IEnumerator WaitToLoadScoreScreen()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("ScoreScreen");
    }

    IEnumerator WaitForNextLevel(string nextLevel)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(nextLevel);

    }

}
