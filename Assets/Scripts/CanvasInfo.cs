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
            StartCoroutine(BlinkText());
            trackIndicatorText.color = Color.red;
        }
        else if (damageTracker.trackLeftDamaged)
        {
            StartCoroutine(BlinkText());
            trackIndicatorText.color = Color.red;
        }
    }
    public IEnumerator BlinkText()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement
        while (true)
        {
            trackIndicatorText.text = "";
            yield return new WaitForSeconds(.5f);
            trackIndicatorText.text = "T";
            yield return new WaitForSeconds(.5f);
        }
    }
}
