using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCorn : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OMH, NOM, NOM!");
        if(col.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
