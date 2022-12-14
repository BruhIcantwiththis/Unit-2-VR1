using UnityEngine;

public class VulmerLR : MonoBehaviour
{
    private float dirX;
    private float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = false;
    private Vector3 localScale;
    public Animator Animator;
    public static bool Damage = false;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX = -1f;
        moveSpeed = 1f;
    }
    void Update()
    {
        if (BadTimeTimer.DieTime == true)
        {
            moveSpeed = 3f;
            Animator.SetBool("Angy", true);
            //gameObject.GetComponent<CircleCollider2D>().enabled = true;
        }
        else
        {
            moveSpeed = 1f;
            Animator.SetBool("Angy", false);
            //gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "DaWall")
        {
            dirX *= -1f;
        }
        if (col.gameObject.tag == "Player")
        {
            PlayerMove.Lives--;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }

    void LateUpdate()
    {
        CheckWhereToFace();
    }

    void CheckWhereToFace()
    {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;
    }
}
