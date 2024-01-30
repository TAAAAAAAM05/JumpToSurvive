using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CheckInventory : MonoBehaviour
{
    public bool checkInv = false;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "GPlayer")
            checkInv = true;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "GPlayer")
            checkInv = false;
    }
}
