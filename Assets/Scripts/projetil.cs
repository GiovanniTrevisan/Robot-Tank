using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class projetil : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5.25f);
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("Inimigo"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            CanvasInfo.tanquesAbatidos++;

            if (CanvasInfo.tanquesAbatidos % 10 == 0)
            {
                PlayerHealth.life += 1;
            }

        }

        if (collision.gameObject.tag == ("MainCamera"))
        {

            PlayerHealth.life -= 1;

        }
    }
}
