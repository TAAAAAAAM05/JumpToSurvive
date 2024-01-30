using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class SaveItems : MonoBehaviour
{
    public CheckInventory checkInventory;
    public Inventory inventory;

    

    public List<string> playerInv = new List<string>();
    public List<bool> collectedItems = new List<bool>(); //testa array
    public List<GameObject> artifacts = new List<GameObject>();

    public bool checkInv;

    public GameObject door1;
    public GameObject door2;
    public GameObject bridge;
    public GameObject winBox;
    private void Start()
    {
        

        artifacts.Add(GameObject.Find("Progress1"));
        artifacts.Add(GameObject.Find("Progress2"));
        artifacts.Add(GameObject.Find("Progress3"));
        artifacts.Add(GameObject.Find("Progress4"));
    }

    void Update()
    {

        checkInv = checkInventory.GetComponent<CheckInventory>().checkInv;
        playerInv = inventory.GetComponent<Inventory>().inventory;
        //Debug.Log(checkInv);
        if (checkInv == true)
        {
            CheckInventory();
           // Progression();
        }
        if (a4 == true)
            Instantiate(winBox, new Vector3(10,10,0), Quaternion.identity);

    }

    bool a1 = false;
    bool a2 = false;
    bool a3 = false;
    bool a4 = false;
    public void CheckInventory()
    {
        

        for (int i = 0; i < playerInv.Count; i++)
        {
            if (playerInv[i] != null)
            {
                if (playerInv[i] == "Artifact1" && a1 == false)
                {
                    Destroy(artifacts[i]);
                    a1 = true;
                    Destroy(door1);
                }
                if (playerInv[i] == "Artifact2" && a2 == false)
                {
                    Destroy(artifacts[i]);
                    a2 = true;
                    Destroy(door2);
                }
                if (playerInv[i] == "Artifact3" && a3 == false)
                {
                    Destroy(artifacts[i]);
                    a3 = true;
                    bridge.transform.position = new Vector2(41, 2.6f);
                }
                if (playerInv[i] == "Artifact4" && a4 == false)
                {
                    Destroy(artifacts[i]);
                    a4 = true;
                }
            }
        }
        
       
        
        
    }
    
    
}
