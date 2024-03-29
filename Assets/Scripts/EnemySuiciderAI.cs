using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySuiciderAI : MonoBehaviour
{
    public Transform player; // Create a reference for the player
    private Rigidbody2D enemyRigidBody;
    private Vector2 movement; // Needed for the enemy to actually move from its initial starting point.
    public float suiciderMoveSpeed;

    public void Start()
    {
        enemyRigidBody = this.GetComponent<Rigidbody2D>();
    }


    public void Update()
    {
        Vector3 direction = player.position - transform.position; // 1. Calculate the difference in distance of the player and enemy object.
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;// 2. Find the arctangent of the difference to get the angle of the player and enemy and then convert to angle since it returns radians.
        enemyRigidBody.rotation = angle - 90; // Need to subtract by 90 degrees to make the enemy object properly look and face the player ship object.
        direction.Normalize();

        movement = direction;
    }

    public void FixedUpdate()
    {
        moveEnemy(movement);
    }


    public void moveEnemy(Vector2 direction)
    {
        //Charge at player without mercy!
        enemyRigidBody.MovePosition((Vector2)transform.position + (direction * suiciderMoveSpeed * Time.deltaTime)); // Time function needed to adjust for varying framerate changes.
    }




}
