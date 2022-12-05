using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Door : MonoBehaviour
{
    public Animator Animator;

    // Update is called once per frame
    void Update()
    {
        if (PlayerMove.CornGot = true)
        {
            Debug.Log("gottem");
            Animator.SetBool("CornAll", true);
        }
        else 
        {
            Animator.SetBool("CornAll", false);
        }
    }
}
