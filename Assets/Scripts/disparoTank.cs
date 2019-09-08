using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoTank : MonoBehaviour
{

    public Rigidbody projetil;
    public Transform Spawnpoint;
    public float velocidade;
    private float fireRateTimer;
    public float fireRateLimite;

    private void Start()
    {
        fireRateTimer = 2f;
    }

    void Update()
    {

        fireRateTimer += Time.deltaTime;
        CanvasInfo.recarregarDisparo = fireRateTimer;

        if (Input.GetButtonDown("Fire1") && fireRateTimer >= fireRateLimite)
        {
            Disparar();
            fireRateTimer = 0f;
        }


    }

    void Disparar()
    {
        Rigidbody clone;
        clone = (Rigidbody)Instantiate(projetil, Spawnpoint.position, projetil.rotation);
        clone.velocity = Spawnpoint.TransformDirection(Vector3.forward * velocidade * 10);
    }

    
}
