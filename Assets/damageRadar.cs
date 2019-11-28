using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageRadar : MonoBehaviour
{
    private string col;
    public static bool radarDamaged;
    private int porc;
    private GameObject canvas;


    private void Start()
    {
        radarDamaged = false;
        col = this.gameObject.tag;

        canvas = GameObject.Find("Canvas");

    }

    private void OnTriggerEnter(Collider other)
    {

        porc = Random.Range(0, 100);

        if (porc < 100)
        {
            if (col == "Lado_traseira" && !radarDamaged)
            {
                radarDamaged = true;
                print("Radar Quebrou");
                canvas.GetComponent<CanvasInfo>().disableRadar();
            }
        }
    }
}
