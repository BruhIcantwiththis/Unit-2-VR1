using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyAngy : MonoBehaviour
{
    public Animator Animator;
    public static bool Angy;
    Transform sprite;
    Vector2 xMove;
    void Start()
    {
        sprite = gameObject.transform;
        xMove = new Vector2(-0.014f, 0.0f);
    }
    void Update()
    {
        if (Angy == true)
        {
            Animator.SetBool("Angy", true);
            float x = Input.GetAxis("Horizontal");
            sprite.Translate(xMove);
        }
    }
}
