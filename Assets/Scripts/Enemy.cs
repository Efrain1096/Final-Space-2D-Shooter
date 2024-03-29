using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SpawnEnemies spawnScript; // Need to drag the object that holds the script
    public GameObject spawnerObject; // Here as well
    public AudioController audioController;

    [SerializeField] private GameObject explosionPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spawnScript = spawnerObject.GetComponent<SpawnEnemies>();
        Bullet bullet = collision.collider.GetComponent<Bullet>(); // Constructor to have enemy be destroyed by the player's projectile.
        Player playerShip = collision.collider.GetComponent<Player>(); // Similar to above, except for it to die when ramming into the player. For the suicider enemy ships.

        if (bullet != null)
        {
            audioController.Audio.PlayOneShot(audioController.death, 0.1f);

            spawnScript.enemyCount--;
            spawnScript.enemyKillCount++;
            spawnScript.totalEnemyKills++;
            Instantiate(explosionPrefab, transform.position, Quaternion.identity); //Will spawn the explosion prefab at the rotation and location of the game object
            Destroy(this.gameObject);
            return;
        }

        if(playerShip != null)
        {
            audioController.Audio.PlayOneShot(audioController.death, 0.1f);

            spawnScript.enemyCount--;
            spawnScript.enemyKillCount++; //The player technically killed the enemy, just not voluntarily so to speak. Kamikaze kills ;)
            spawnScript.totalEnemyKills++;

            Instantiate(explosionPrefab, transform.position, Quaternion.identity); 
            Destroy(this.gameObject);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            return;
        }
    }
}
