using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject findEnemy;
    public EnemyLife enemyCounter;

    float timer = 10f;
    int nrEnemy;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //nrEnemy får aldrig ett nytt värde när en klon skapas.

        enemyCounter = findEnemy.GetComponent<EnemyLife>();
        nrEnemy = enemyCounter.nrEnemy;

        if (timer > 0)
            timer -= Time.deltaTime;
        else
        {
            if (nrEnemy != 1)
            {
                timer = 10;
                Instantiate(findEnemy, this.transform);
                nrEnemy = 1;
            }
        }

        
    }
}
