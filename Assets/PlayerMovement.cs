using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpForce = 16f;
    private bool isFacingRight = true;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    public ParticleSystem dust;

    private Rigidbody2D platformRb;

    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Flip();

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            dust.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if (platformRb)
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y) + platformRb.velocity * Vector2.right;
        }
        else
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
            if (IsGrounded())
            {
                dust.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            transform.parent = collision.transform;
            platformRb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.gravityScale = 4; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            transform.parent = null;
            platformRb = null;
            rb.gravityScale = 4; 
        }
    }
}
