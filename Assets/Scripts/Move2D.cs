using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{

    Rigidbody2D playerShip;
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    Vector3 rotation = new Vector3(0f, 0f, -90f);

    private void Update()
    {

        MoveHorizontal();
        MoveVertical();
    }


    public void MoveHorizontal()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

    }

    public void MoveVertical()
    {
        Vector3 movement = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }





}
