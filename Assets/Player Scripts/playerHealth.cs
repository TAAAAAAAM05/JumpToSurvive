using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public IsGroundedCheck groundCheck;

    public bool water;

    public int hp = 6;
    public GameObject hp3;
    public GameObject hp2;
    public GameObject hp1;
    public GameObject gameOver;
    public GameObject winBox;

    // Update is called once per frame
    void Update()
    {
        water = groundCheck.water;

        if (water == true)
            hp = 0;

        if (hp == 0)
        {
            Destroy(hp1);
            gameOver.transform.position = transform.position;
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Finish")
        {
            winBox.transform.position = transform.position;
            Time.timeScale = 0;
        }

        if (collision.collider.tag == "Enemy")
        {
            hp -= 2;
            Destroy(collision.gameObject);
        }
        
        

        if (hp == 4)
            Destroy(hp3);
        if (hp == 2)
            Destroy(hp2);
    }
}
