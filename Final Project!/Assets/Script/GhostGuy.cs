using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGuy : MonoBehaviour
{
    public Animator Animator;
    void Update()
    {
        if(BadTimeTimer.DieTime == true)
        {
            Animator.SetBool("Angy", true);
        }
    }
}
