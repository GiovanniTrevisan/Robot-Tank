using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int StartHealth = 1;
    public int scorePoint = 1;

    bool EnemyisDead = false;
    int CurrentHealth;

    void Start()
    {
        CurrentHealth = StartHealth;
    }

    void Update()
    {
        
    }

    public void ChangeHealth(int amount)
    {

        if (EnemyisDead == false)
        {

            CurrentHealth = CurrentHealth + amount;
            if (CurrentHealth <= 0)
            {
                EnemyisDead = true;

                Destroy(gameObject, 2f);

            }
        }
    }
}
