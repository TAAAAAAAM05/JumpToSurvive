using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeR : MonoBehaviour
{
    public bool edgeDetectedR;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            edgeDetectedR = false;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            edgeDetectedR = true;
    }
}
