using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    public float heroSpeed;
    public float jumpForce;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float horisontalDirection = Input.GetAxis("Horizontal");
        anim.SetFloat("horizontalDirection", Mathf.Abs(horisontalDirection));

        rb.velocity = new Vector2(horisontalDirection * heroSpeed, rb.velocity.y);

        if(horisontalDirection < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if(horisontalDirection > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("jump");
            rb.AddForce(Vector2.up * jumpForce , ForceMode2D.Impulse);
        }
    }


}
