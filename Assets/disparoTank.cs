using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoTank : MonoBehaviour
{

    public GameObject projetil;
    private Rigidbody projetilFisics;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject fire = Instantiate(projetil);
            projetilFisics = fire.GetComponent<Rigidbody>();
            projetilFisics.AddForce(transform.forward * 100f);
        }
    }
}
