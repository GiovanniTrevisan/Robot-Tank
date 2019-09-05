using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cycleDayNight : MonoBehaviour
{
    public float speed;

    //CANVAS
    public Text day;
    public Text hours;

    public static float t;

    int daysPassed;
    public static int hoursPassed;
    bool passed = true;
    bool dayPassed = true;

    object objLock = new object();

    public event EventHandler DayElapsed;
    public event EventHandler HourElapsed;

    // Start is called before the first frame update
    void Start()
    {
        DayElapsed += CycleDayNight_DayElapsed;
        HourElapsed += CycleDayNight_HourElapsed;

        daysPassed = 0;
        hoursPassed = 15;
    }

    private void CycleDayNight_HourElapsed(object sender, EventArgs e)
    {
        if(hoursPassed == 23)
        {
            hoursPassed = 0;
        }
        else
        {
            hoursPassed++;
        }
        
    }

    private void CycleDayNight_DayElapsed(object sender, EventArgs e)
    {
        daysPassed++; ;
    }

    void Update()
    {

        hours.text = hoursPassed.ToString();
        day.text = daysPassed.ToString();

        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);


        var x = transform.localRotation.eulerAngles;
        {
            var angle = Convert.ToInt32(x.x);
            if (angle == -90 || angle == 270)
            {
                if (!dayPassed)
                {
                    dayPassed = true;
                    DayElapsed?.Invoke(this, new EventArgs());
                }
            }
            else
            {
                dayPassed = false;
            }

            if (angle % 15 == 0)
            {
                if (!passed)
                {
                    passed = true;
                    HourElapsed?.Invoke(this, new EventArgs());
                }
            }
            else
            {
                passed = false;
            }
        }
    }

    public class HourElapsedEventArgs : EventArgs
    {
        public int CurrentHour { get; set; }
    }
}
