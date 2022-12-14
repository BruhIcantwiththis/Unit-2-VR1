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
    public static float Acornum;
    public static int Lives = 3;
    public bool CornGot = false;
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
        Move.y = updown * Thrust * 2;
        player.Translate(Move * Time.deltaTime);
        Animator.SetFloat("Speed", Mathf.Abs(leftright));
        Animator.SetFloat("UP", Mathf.Abs(updown));
        if (leftright > 0)
        {
            player.localScale = new Vector3(5.0f, 5.0f, 1.0f);
        }
        if (leftright < 0)
        {
            player.localScale = new Vector3(-5.0f, 5.0f, 1.0f);
        }
        if (Lives == 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(2);
        }
        if (Acornum == 20)
        {
            CornGot = true;
        }
        }
    void OnBecomeInvisible()
        {
        Debug.Log("Off Cam");
        Destroy(gameObject);
        SceneManager.LoadScene(2);
        }
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "ant")
        {
            Debug.Log("OUCH!");
            Lives--;
            Animator.SetBool("Pain", true);
        }
        else { Animator.SetBool("Pain", false); }
        if (col.gameObject.tag == "acorn")
        {
            Acornum += 1;
        }
    }
}