using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimientoBlendTree : MonoBehaviour
{
    float horizontalInput;
    float moveSpeed = 5f;
    bool isFacingRight = true;
    float jumpPower = 8f;
    bool isGrounded = false;

    Rigidbody2D rb;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        FlipSprite();

        if(Input.GetButtonDown("Jump") && isGrounded){
            rb.linearVelocity = new Vector2(rb.velocity.x,jumpPower);
            isGrounded = false;
            animator.SetBool("isJumping",! isGrounded);
        }
    }

    [System.Obsolete]
    private void FixedUpdate()
    {
        rb.velocity= new Vector2(horizontalInput * moveSpeed,  rb.velocity.y);
        animator. SetFloat("xVelocity", Math.Abs( rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    void FlipSprite()
    {
      if(isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput >0f )
      {
        isFacingRight = !isFacingRight;
        Vector3 ls = transform.localScale;
        ls.x *= -1f;
        transform.localScale = ls;
      }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        animator.SetBool("isJumping", ! isGrounded);
    }


}
