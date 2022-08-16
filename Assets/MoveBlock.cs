using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed;
    public float inputSpeed;
    public float top;
    public float bottom;
    private bool check;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        speed = inputSpeed * -1;
    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Yellow")
        {
            check = true;
        }
    }
    void FixedUpdate()
    {
        if (true == true) {
            //右に移動
            if (transform.position.y > top)
            {
                speed = inputSpeed * -1;
            }
        //左に移動
            else if (transform.position.y < bottom)
            {
                speed = inputSpeed;
            }
            // キャラクターを移動 Vextor2(x軸スピード、y軸スピード(元のまま))
            rb2d.velocity = new Vector2(rb2d.velocity.x, speed);
        }
    }
}
