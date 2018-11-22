using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLine : MonoBehaviour
{
    float time = 0;
    bool running = false;

    void Update()
    {
        if (running)
        {
            time++;
        }
    }

    void StartTime()
    {
        running = true;
    }

    void PauzeTime()
    {
        running = false;
    }

    void ResetTime()
    {
        time = 0;
    }
}
