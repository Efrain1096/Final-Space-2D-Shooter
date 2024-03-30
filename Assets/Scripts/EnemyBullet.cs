using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private float bulletSpeed = 2.0f;

    Rigidbody2D bullet;

    private void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
        Vector2 force = transform.right * bulletSpeed;
        bullet.AddForce(force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
