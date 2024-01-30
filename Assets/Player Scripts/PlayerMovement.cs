using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public IsGroundedCheck groundCheck;
    public IsClimbingCheck climbingCheck;
    
    public float jumpForce = 0f;
    bool grounded;
    bool climbing;
    float gravityScale = 5f;
    float gravityScaleFall = 15f;
    public float jumpWindow = 1f;
    public float cancelForce = 20f;
    bool jumpRelease = true;

    public float playerSpeed = 0f;
    public float climbSpeed = 0f;
    float moveSpeed;

    bool facingRight;

    private void Update()
    {
        grounded = groundCheck.isGrounded;
        climbing = climbingCheck.isClimbing;

        if (Input.GetKeyUp(KeyCode.Space))
            jumpRelease = true;

        if (climbing == true && Input.GetKey(KeyCode.Space))
        {
            rb.gravityScale = 0f;
        }
        if (climbing == true && Input.GetKeyUp(KeyCode.Space) || climbing == false && rb.velocity.y <= 0f)
            rb.gravityScale = gravityScaleFall;

    }
    void FixedUpdate()
    {
        MoveSpeed();
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector2.right * moveSpeed);
            if (facingRight)
                Flip();
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector2.left * moveSpeed);
            if (!facingRight)
                Flip();
        }

        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
            Jump();
        }
        
    }
    

    
    void Jump()
    {
        if (jumpRelease)
        {

            jumpRelease = false;
            rb.gravityScale = gravityScale;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        
        }
        
    }
    void MoveSpeed()
    {
        if (climbing == true)
            moveSpeed = climbSpeed;
        else
            moveSpeed = playerSpeed;
    }
    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
    /*
    void JumpCancel()
    {
        if (jumping)
        {
            jumpTime += Time.deltaTime;

            if (jumpTime < jumpWindow && Input.GetKeyUp(KeyCode.Space))
            {
                jumpCancelled = true;
            }

            if (rb.velocity.y < 0)
            {
                rb.gravityScale = gravityScaleFall;
                jumping = false;
            }

        }
        if (jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * cancelForce);
        }
    }
    */
}
