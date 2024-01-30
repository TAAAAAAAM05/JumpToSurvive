using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsClimbingCheck : MonoBehaviour
{
    

    public bool isClimbing;
    bool jumping;
    bool climb;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            jumping = true;
        }

        if (jumping && climb)
            isClimbing = true;
        else
            isClimbing = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
            climb = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
            climb = true;
    }
}
