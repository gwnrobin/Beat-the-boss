using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLine : MonoBehaviour
{
    public float rawTime = 0;
    public float roundedTime = 0;
    bool running = false;

    void Update()
    {
        if (running)
        {
            rawTime += Time.deltaTime;
            roundedTime = Mathf.Round(rawTime * 10) / 10;
        }
    }

    public void StartTime()
    {
        running = true;
    }

    public void PauzeTime()
    {
        running = false;
    }

    public void ResetTime()
    {
        rawTime = 0;
    }
}
