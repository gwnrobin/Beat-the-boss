using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    TimeLine timeLine;// = new TimeLine();

    List<TimeEvent> events = new List<TimeEvent>();

    void Awake()
    {

    }

    void Start()
    {
        timeLine.StartTime();
    }
	
    void Update()
    {
        print(timeLine.time);
    }
}
