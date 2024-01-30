using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<string> inventory = new List<string>();
    public List<GameObject> spawnA = new List<GameObject>();

    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;

    private void Start()
    {
        inventory.Clear();

        spawnA.Add(a1);
        spawnA.Add(a2);
        spawnA.Add(a3);
        spawnA.Add(a4);

        //Instantiate(spawnA[0]);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Artifact" && tag == "Player")
        {
            inventory.Add(collision.gameObject.name);
            Destroy(collision.gameObject);

            if (collision.gameObject.name == "Artifact1" && inventory.Count > 1)
                inventory.RemoveAt(1);
            if (collision.gameObject.name == "Artifact2" && inventory.Count > 2)
                inventory.RemoveAt(2);
            if (collision.gameObject.name == "Artifact3" && inventory.Count > 3)
                inventory.RemoveAt(3);
            if (collision.gameObject.name == "Artifact4" && inventory.Count > 4)
                inventory.RemoveAt(4);
        }
        
        
    }

}
