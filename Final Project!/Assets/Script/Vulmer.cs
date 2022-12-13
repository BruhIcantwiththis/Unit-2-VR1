using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vulmer : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }

        }
       void OnCollisionEnter2D(Collision2D col)
    {
     if (col.gameObject.tag == "DaWall")
        {
            Debug.Log("E");
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }

        }
    }
}