using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private Vector3 pos;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 7)
        {
            transform.position = pos;
            _rigidbody.velocity = Vector2.zero;
        }
    }
}
