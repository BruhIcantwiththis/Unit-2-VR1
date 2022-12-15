using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    Transform Door;
    Vector2 Move;
    void Update()
    {
        if ( SpookyAngy.Angy == true)
        {
            transform.position = new Vector3(3.59f, 0.515f, 0f);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(4);
        }
    }
}
