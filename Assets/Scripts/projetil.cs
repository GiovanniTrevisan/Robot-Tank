﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class projetil : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3.25f);
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("Inimigo"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            CanvasInfo.tanquesAbatidos++;
        }

        if (collision.gameObject.tag == ("MainCamera"))
        {

            PlayerHealth.life -= 1;

            print("-1 de vida");

        }
    }
}
