using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLine : MonoBehaviour
{
    public float time = 0;
    bool running = false;

    void Update()
    {
        if (running)
        {
            time += Time.deltaTime;
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
        time = 0;
    }
}
