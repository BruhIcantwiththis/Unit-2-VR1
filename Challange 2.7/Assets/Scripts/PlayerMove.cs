using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector2 Move;
    Transform player;
    public Animator Animator;
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Move = new Vector2(2.0f, 0.0f);
        player = gameObject.transform;
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float leftright = Input.GetAxis("Horizontal");
        float updown = Input.GetAxis("Vertical");
        Move.x = leftright;
        Move.y = updown;
        player.Translate(Move * Time.deltaTime);
        Animator.SetFloat("Speed", Mathf.Abs(leftright));
        if (leftright > 0)
        {
            player.localScale = new Vector3(5.0f, 5.0f, 1.0f);
        }
        if (leftright < 0)
        {
            player.localScale = new Vector3(-5.0f, 5.0f, 1.0f);
        }
    }
}
