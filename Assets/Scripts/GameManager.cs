using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private TimeLine timeLine;

    public Level level;

    bool cd = false;
    float procTime;

    private void Awake()
    {
        timeLine = GetComponent<TimeLine>();
        //level = GameObject.Find("Variables").GetComponent<GameVariables>().GetLevel();
        //Destroy(GameObject.Find("Variables"));
    }

    private void Start()
    {
        timeLine.StartTime();
    }
	
    private void Update()
    {
        for(int i = 0; i < level.events.Count; i++)
        {
            if (level.events[i].time == timeLine.roundedTime && !cd)
            {
                InstatiatieEvent(level.events[i].e.eventSpawns);
                procTime = timeLine.roundedTime;
                cd = true;
            }
        }
        if(cd && procTime + 1 < timeLine.roundedTime)
        {
            cd = false;
        }
    }

    private void InstatiatieEvent(List<GameObject> eventObjects)
    {
        for (int i = 0; i < eventObjects.Count; i++)
        {
            Instantiate(eventObjects[i]);
        }
    }
}
