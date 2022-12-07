using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyFrag : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Get Key Fragment");
        if(col.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
