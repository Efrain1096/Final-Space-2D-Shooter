using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioController audioController;

    [SerializeField] private GameObject explosionPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
     
        EnemyBullet bullet = collision.collider.GetComponent<EnemyBullet>();
        Enemy enemyShip = collision.collider.GetComponent<Enemy>();
        audioController.Audio.PlayOneShot(audioController.death);


        if (bullet != null)
        {
            
            Instantiate(explosionPrefab, transform.position, Quaternion.identity); //Will spawn the explosion prefab at the rotation and location of the game object
            Destroy(gameObject, 1.0f);
            return;
        }

         if(enemyShip != null)
        {
            
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject, 1.0f);
            return;
        }

        Player enemy = collision.collider.GetComponent<Player>();
        if (enemy != null)
        {
            return;
        }



    }





}
