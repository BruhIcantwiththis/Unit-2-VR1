using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 Move;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Move = new Vector2 (2.0f, 0.0f);
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float arrowInput = Input.GetAxis("Horizontal");
        float upandown = Input.GetAxis("Vertical");
        Move.x = arrowInput;
        Move.y = upandown;
        player.Translate(Move*Time.deltaTime);
        Vector2 flip = new Vector2(-1.0f, 1.0f);
        transform.localScale *= flip;
    }
}
