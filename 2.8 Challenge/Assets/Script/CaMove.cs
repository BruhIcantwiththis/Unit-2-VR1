using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaMove : MonoBehaviour
{
    Vector2 moveUp;
    Transform camera;
    Vector2 moveLeft;
    // Start is called before the first frame update
    void Start()
    {
        moveUp = new Vector2(0.0f, 1.0f);
        camera = gameObject.transform;
        moveLeft = new Vector2(-1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        camera.Translate(moveUp * Time.deltaTime);
    }
}
