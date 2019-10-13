using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class projetil : MonoBehaviour
{

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

            print("-1 de vida");

        }
    }
}
