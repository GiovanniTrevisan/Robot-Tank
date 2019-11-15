using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageTracker : MonoBehaviour
{

    private string col;
    public static bool trackRightDamaged;
    public static bool trackLeftDamaged;
    private int porc;
    private GameObject canvas;


    private void Start()
    {
        trackRightDamaged = false;
        trackLeftDamaged = false;
        col = this.gameObject.tag;

        canvas = GameObject.Find("Canvas");

    }

    private void OnTriggerEnter(Collider other)
    {

        porc = Random.Range(0, 100);

        if (porc < 50)
        {
            if (col == "Lado_direito" && !trackRightDamaged)
            {
                trackRightDamaged = true;
                print("tracker direito Quebrou");
                canvas.GetComponent<CanvasInfo>().changeColorTrackerInd();
            }

            if (col == "Lado_esquerdo" && !trackLeftDamaged)
            {
                trackLeftDamaged = true;
                print("tracker esquerdo Quebrou");

                canvas.GetComponent<CanvasInfo>().changeColorTrackerInd();
            }

        }
    }
}
