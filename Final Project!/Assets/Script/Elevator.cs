using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Animator Animator;
    public static bool Open;
    void Update()
    {
        if(PlayerMove.RedKey == 1)
        {
            Animator.SetBool("RedKey", true);
            Open = true;
        }
    }
}
