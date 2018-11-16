using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform, minutesTransform, secondsTransform;
    const float degreesPerHours = 30f;
    public bool isContinuous=true;

	void Update ()
    {
        if (isContinuous)
        {
            Continuous();
        }
        else {
            Discrete();
        }

    }

    public void Continuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = Quaternion.Euler(0f,(float) time.TotalHours * degreesPerHours, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * 6f, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * 6f, 0f);
    }
    public void Discrete()
    {
        hoursTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHours, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Hour * 6f, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Hour * 6f, 0f);
    }
}
