using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField]private string newLevel;
    Transform Door;
    Vector2 Move;
    void Update()
    {
        if(PlayerMove.KeyFixed==true)
        {
            transform.position = new Vector3(38.402f, 17.923f, 0f);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
