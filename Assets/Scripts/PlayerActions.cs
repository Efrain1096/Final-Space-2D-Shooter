using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public GameObject bulletPrefab; //Drop in bullet prefab
    public Transform firePoint;

    public AudioController audioController;


    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioController.Audio.PlayOneShot(audioController.playerFireSound, 0.15f);
            ShootStandardProjectile();
        }
   
        /*if (Input.GetKey(KeyCode.Mouse0)) // Works for holding down the left primary mouse button
        {
            ShootStandardProjectile();
        }*/
    }

    private void ShootStandardProjectile()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
        Destroy(bullet, 5f);

    }

    



}
