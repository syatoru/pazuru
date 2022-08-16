using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCharMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed;
    public float inputSpeed;
    private Animator anim;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        _rigidbody = this.GetComponent<Rigidbody2D>();
        speed = inputSpeed;
    }
    void Update()
    {
        anim.SetFloat("Speed", speed);
        if(transform.position.x >= 70)
        {
            string sceneName = SceneManager.GetActiveScene().name;
            if (sceneName == "ending")
                FadeManager.Instance.LoadScene("ending2", 1.0f);
            if (sceneName == "ending2")
                FadeManager.Instance.LoadScene("title", 2.0f);
        }
    }
    void FixedUpdate()
    {
        // キャラクターを移動 Vextor2(x軸スピード、y軸スピード(元のまま))
        rb2d.velocity = new Vector2(speed, 0);
    }
}
