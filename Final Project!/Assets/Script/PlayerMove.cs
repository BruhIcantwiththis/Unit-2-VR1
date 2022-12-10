using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Vector2 Move;
    Transform player;
    public Animator Animator;
    Rigidbody m_Rigidbody;
    float Thrust = 5f;
    public static int Lives = 3;
    public static int KeyBits = 0;
    public bool KeyFixed = false;
    // Start is called before the first frame update
    void Start()
    {
       Move = new Vector2(2.0f, 0.0f);
       player = gameObject.transform;
       m_Rigidbody = GetComponent<Rigidbody>();
        Lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        float leftright = Input.GetAxis("Horizontal");
        float updown = Input.GetAxis("Vertical");
        Move.x = leftright * Thrust;
        Move.y = updown * Thrust;
        player.Translate(Move * Time.deltaTime);
        if (leftright > 0)
        {
            Animator.SetBool("Right", true);
        }
        else { Animator.SetBool("Right", false); }
        if (leftright < 0)
        {
            Animator.SetBool("Left", true);
        }
        else { Animator.SetBool("Left", false); }
        if(updown > 0)
        {
            Animator.SetBool("Up", true);
        }
        else { Animator.SetBool("Up", false); }
        if(updown < 0)
        {
            Animator.SetBool("Down", true);
        }
        else { Animator.SetBool("Down", false); }
        if (Lives == 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(0);
        }
        if ( KeyBits == 10)
        {
            KeyFixed = true;
        }
        }
    void OnBecomeInvisible()
        {
        Debug.Log("Off Cam");
        Destroy(gameObject);
        SceneManager.LoadScene(0);
        }
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Vulmer")
        {
            Debug.Log("OUCH!");
            Lives--;
            Animator.SetBool("Pain", true);
        }
        else { Animator.SetBool("Pain", false); }
        if (col.gameObject.tag == "KeyFrag")
        {
            KeyBits += 1;
        }
    }
}