using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRedKey : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
