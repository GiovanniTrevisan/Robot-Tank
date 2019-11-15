using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public static int life;

    public GameObject canvasGameOver;

    // Start is called before the first frame update
    void Start()
    {
        life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            canvasGameOver.SetActive(true);
            Destroy(gameObject);
        }
    }
}
