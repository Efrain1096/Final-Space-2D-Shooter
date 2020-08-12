using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public AudioController audioController;

    public GameObject bulletPrefab; //Drop in bullet prefab
    public Transform firePoint;
    public float shooterFireRate =0.5f;
    public float nextShot = 0.0f;
    private void Update()
    {
        if(Time.time > nextShot)
        {

            nextShot = Time.time + shooterFireRate;
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
        if (transform.position.x > -9.0) 
        {
            audioController.Audio.PlayOneShot(audioController.enemyFireSound, 0.02f); // Fire sound effect is activated for whenever an enemy shoots
            GameObject bullet = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
            Destroy(bullet, 10f);
        }
           
    }
}
