using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float speed;
    Vector2 input;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Animate();
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if(horizontal == 0 && vertical == 0)
        {
            rb.velocity = new Vector2(0, 0);
            return;
        }

        input = new Vector2(horizontal, vertical);
        rb.velocity = input * speed * Time.fixedDeltaTime;
    }

    void Animate()
    {
        anim.SetFloat("Xmove", input.x);
        anim.SetFloat("Ymove", input.y);
    }
}
