using System.Collections;
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
        print(collision.gameObject.tag);

        if (collision.gameObject.tag == ("Inimigo"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
