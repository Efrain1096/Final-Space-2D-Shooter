using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseAim : MonoBehaviour
{


    private void Update()
    {

        Vector3 mousePosition = Input.mousePosition;

        Vector3 gunPosition = Camera.main.WorldToScreenPoint(transform.position);
        mousePosition.x -= gunPosition.x;
        mousePosition.y -= gunPosition.y;


        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(180f,0f, -angle - 90));

      /*  if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
        {
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));

        }*/
    }






}
