using System;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {
    const float hoursToDegree = -30f, minutesToDegree = -6f, secondsToDegree = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Update() {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegree * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegree * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegree * (float)time.TotalSeconds);
    }
}
