﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] spanwPoints;
    public int IndexObject;

    private int enemyNum;


    void Start()
    {
        enemyNum = 0;
        StartCoroutine("SpawnEnemyCoroutine");
    }

    void Update()
    {

        enemyNum = GameObject.FindGameObjectsWithTag("Inimigo").Length;

        IndexObject = Random.Range(0, (spanwPoints.Length));

        //print(enemyNum);

        if(enemyNum < 3)
        {
            StartCoroutine("SpawnEnemyCoroutine");
        }



    }

    IEnumerator SpawnEnemyCoroutine()
    {
        Instantiate(enemy, spanwPoints[IndexObject].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
    }
}