using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerDetection playerDetectedCheck;
    public GameObject findPlayer;
    public Transform player;
    //public EdgeR edgeDetectedRCheck;

    float turnCounter = 0f;
    public float maxVelocity;
    float moveSpeed;
    public float chaseSpeed;
    public float turnSpeed;
    Vector2 playerLocation;
    bool playerDetected;
    public float range;
    bool right;
    //bool edgeDetectedR;
    //int runAway = 2;

    private void Start()
    {
        findPlayer = GameObject.FindGameObjectWithTag("Player");
        player = findPlayer.GetComponent<Transform>();
    }
    void Update()
    {
        playerLocation = new Vector2(player.position.x, transform.position.y);

        if (playerLocation.x - transform.position.x > 0)
            right = true;
        else
            right = false;

        playerDetected = playerDetectedCheck.playerDetected;

        if (turnCounter > 0f)
            turnCounter -= Time.deltaTime;

        Movespeed();
        Movement(right);

    }

    private void Movement(bool right)
    {
        if (playerDetected)
        {
            //if (transform.position.x > player.position.x)
                //transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), moveSpeed * Time.deltaTime);
            if (right && rb.velocity.x < maxVelocity)
            {

                rb.AddForce(Vector2.right * moveSpeed * Time.deltaTime, ForceMode2D.Force);
            }
            if (!right && rb.velocity.x > -maxVelocity)
                rb.AddForce(Vector2.right * -moveSpeed * Time.deltaTime, ForceMode2D.Force);

            //transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), moveSpeed * Time.deltaTime);
        }
    }

    
    private void Movespeed()
    {
        moveSpeed = turnSpeed;
        /*
        if (rb.velocity.x == 0f)
        {
            turnCounter = 0.3f;
        }
        if (turnCounter > 0f)
            moveSpeed = turnSpeed;
        else
            moveSpeed = chaseSpeed;
        */
    }

    /*
    private void MovementYesPlayer()
    {
        if (Vector2.Distance(player.position, transform.position) > range && runAway == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), moveSpeed * Time.deltaTime);
            if (edgeDetectedR == true)
            {
                //transform.position = new Vector2(0, 0);
                runAway = 2;
            }
        }
        else if (Vector2.Distance(player.position, transform.position) < range - 1 && runAway == 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), -moveSpeed * Time.deltaTime);
            if (edgeDetectedR == true)
            {
                runAway = 1;
                
                //transform.position = new Vector2(0, 0);
            }
        }
    }
    
    private void MovementNoPlayer()
    {
        counter += Time.deltaTime;

        if (counter > 4)
        {
            direction = Random.Range(0, 3);

            counter = 0;
        }

        switch (direction)
        {
            case 1:
                rb.velocity = new Vector2(moveSpeed * Time.deltaTime, rb.velocity.y);
                break;
            case 2:
                rb.velocity = new Vector2(-moveSpeed * Time.deltaTime, rb.velocity.y);
                break;
        }
    }
    */
    
}
