using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public float timer;
    public int nrEnemy;
    private void Awake()
    {
        timer = 3;
        nrEnemy++;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(nrEnemy);
        if (timer > 0)
            timer -= Time.deltaTime;
        else
        {
            nrEnemy--;
            Destroy(gameObject);
        }
    }
}
