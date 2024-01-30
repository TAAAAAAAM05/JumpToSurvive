using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public bool playerDetected;
    public GameObject findPlayer;
    public Transform player;
    public float detectionRange;
    bool detectionActivated = true;

    private void Start()
    {
        findPlayer = GameObject.FindGameObjectWithTag("Player");
        player = findPlayer.GetComponent<Transform>();
    }
    void Update()
    {
        if (detectionActivated)
        {
            if (Vector2.Distance(player.position, transform.position) <= detectionRange)
            {
                playerDetected = true;
                detectionActivated = false;
            }
        }

    }
}
