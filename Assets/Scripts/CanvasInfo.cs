using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasInfo : MonoBehaviour
{


    //CANVAS
    public Text tanquesAbatidosText;
    public static int tanquesAbatidos;


    void Start()
    {
        tanquesAbatidos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tanquesAbatidosText.text = tanquesAbatidos.ToString();
    }
}
