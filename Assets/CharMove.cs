using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 17;
    public float jumpForce = 1000f;
    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer spRenderer;
    private bool isGround;
    public bool jampCheck;
    public bool YellowCheck = false;
    public bool Clear;
    private Vector3 pos;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        this.spRenderer = GetComponent<SpriteRenderer>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -60)
        {
            transform.position = pos;
        }
        float x = Input.GetAxisRaw("Horizontal");

        if (x > 0)
        {
            spRenderer.flipX = true;
        }
        else if (x < 0)
        {
            spRenderer.flipX = false;
        }

        rb2d.velocity = new Vector2(x * speed, rb2d.velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));

        if (Input.GetButtonDown("Jump") & isGround)
        {
            if (jampCheck == false)
            {
                jampCheck = true;
            }
            else
            {
                jampCheck = false;
            };
            rb2d.AddForce(Vector2.up * jumpForce);
        }

        float velX = rb2d.velocity.x;
        float velY = rb2d.velocity.y;

        if (Mathf.Abs(velX) > 20)
        {

            if (velX > 20.0f)
            {
                rb2d.velocity = new Vector2(20.0f, velY);
            }
            if (velX < -20.0f)
            {
                rb2d.velocity = new Vector2(-20.0f, velY);
            }
        }
    }
    private void FixedUpdate()
    {
        isGround = false;
        Vector2 groundPos =
            new Vector2(
                transform.position.x,
                transform.position.y

                );
        Vector2 groundArea = new Vector2(0.5f, 0.5f);
        isGround =
            Physics2D.OverlapArea(
                groundPos + groundArea,
                groundPos - groundArea,
                groundLayer
                );
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Clear")
        {
            transform.position = pos;


            string sceneName = SceneManager.GetActiveScene().name;
            if (sceneName == "1men")
                FadeManager.Instance.LoadScene("2men", 0.3f);
            if (sceneName == "2men")
                FadeManager.Instance.LoadScene("3men", 0.3f);
            if (sceneName == "3men")
                FadeManager.Instance.LoadScene("4men", 0.3f);
            if (sceneName == "4men")
                FadeManager.Instance.LoadScene("ending", 4.0f);
        }
    }
}