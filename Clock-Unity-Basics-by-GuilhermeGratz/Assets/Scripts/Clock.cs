using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    public bool constantFlow = false;

    private void FixedUpdate()
    {
        const float hoursToDegrees = -30.0f, minutesToDegrees = -6.0f, secondsToDegrees = -6.0f;
        if (constantFlow)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;

            hoursPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, hoursToDegrees * (float)time.TotalHours);
            minutesPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, minutesToDegrees * (float)time.TotalMinutes);
            secondsPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, secondsToDegrees * (float)time.TotalSeconds);
        }
        else { 
            DateTime now = DateTime.Now;

            hoursPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, hoursToDegrees * now.Hour);
            minutesPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, minutesToDegrees * now.Minute);
            secondsPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, secondsToDegrees * now.Second);
        }
    }
}
