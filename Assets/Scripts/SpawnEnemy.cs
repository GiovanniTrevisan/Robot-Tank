using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] spanwPoints;
    private int IndexObject;

    private int enemyNum;


    void Start()
    {
        enemyNum = 0;
    }

    void Update()
    {

        enemyNum = GameObject.FindGameObjectsWithTag("Inimigo").Length;

        IndexObject = Random.Range(0, (spanwPoints.Length));

        if (enemyNum < cycleDayNight.daysPassed + 1)
        {
            if (spanwPoints[IndexObject] != null)
            {
                Instantiate(enemy, spanwPoints[IndexObject].transform.position, Quaternion.identity);
            }
        }
    }
}
