using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smiler : MonoBehaviour
{
    public Animator Animator;
    void Update()
    {
        if (BadTimeTimer.DieTime == true)
        {
            Animator.SetBool("Angy", true);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            Animator.SetBool("Angy", false);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.tag == "Player")
            {
                PlayerMove.Lives--;
            }
        }
}
