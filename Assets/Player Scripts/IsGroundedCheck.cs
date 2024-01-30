using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGroundedCheck : MonoBehaviour
{
    public bool water;
    public bool isGrounded;
    private void Start()
    {
        water = false;
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
            isGrounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
            isGrounded = true;
        if (collision.collider.tag == "Water")
            water = true;
    }

}
