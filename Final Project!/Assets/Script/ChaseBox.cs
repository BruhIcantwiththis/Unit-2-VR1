using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaceBox : MonoBehaviour
{
    [SerializeField] private string newLevel;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SpookyAngy.Angy = true;
        }
    }
}