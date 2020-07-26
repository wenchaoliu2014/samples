using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float
        DegreesPerHour = 30f,
        DegreesPerMinute = 6f,
        DegreesPerSecond = 6f;

    public Transform hoursTransform, minutesTransform, secondsTransform;

    public bool continuous;
    

    void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float) time.TotalHours * DegreesPerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler(0f, (float) time.TotalMinutes * DegreesPerMinute, 0f);
        secondsTransform.localRotation =
            Quaternion.Euler(0f, (float) time.TotalSeconds * DegreesPerSecond, 0f);
    }

    void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation =
            Quaternion.Euler(0f, time.Hour * DegreesPerHour, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler(0f, time.Minute * DegreesPerMinute, 0f);
        secondsTransform.localRotation =
            Quaternion.Euler(0f, time.Second * DegreesPerSecond, 0f);
    }
}