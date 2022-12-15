using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSneekL : MonoBehaviour
{
    public BoxCollider2D collider;
    void Update()
    {
        if(PlayerMove.RedKey == 0)
        {
            collider.isTrigger= true;
        }
        if (PlayerMove.RedKey == 1)
        {
          collider.isTrigger = false;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}