using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasInfo : MonoBehaviour
{


    //CANVAS
    public Text tanquesAbatidosText;
    public static int tanquesAbatidos;
    public Slider mySlider;
    public static float recarregarDisparo;
    public Text trackIndicatorText;

    public Text lifeText;


    void Start()
    {
        tanquesAbatidos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tanquesAbatidosText.text = tanquesAbatidos.ToString();
        lifeText.text = PlayerHealth.life.ToString();
        mySlider.value = recarregarDisparo;
    }

    public void changeColorTrackerInd()
    {
        if(damageTracker.trackRightDamaged && damageTracker.trackLeftDamaged)
        {
            trackIndicatorText.color = Color.black;
        }
        else if (damageTracker.trackRightDamaged)
        {
            trackIndicatorText.color = Color.red;
        }
        else if (damageTracker.trackLeftDamaged)
        {
            trackIndicatorText.color = Color.red;
        }
    }
}
