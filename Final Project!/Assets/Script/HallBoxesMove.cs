using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallBoxesMove : MonoBehaviour
{
    Transform Boxes;
    Vector2 Move;
    void Update()
    {
        if (SpookyAngy.Angy == true)
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}
