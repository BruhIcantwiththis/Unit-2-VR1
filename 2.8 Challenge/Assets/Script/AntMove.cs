using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntMove : MonoBehaviour
{
    Transform sprite;
    Vector2 xMove;
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.transform;
        xMove = new Vector2(-0.01f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        sprite.Translate(xMove);
        
    }
}
