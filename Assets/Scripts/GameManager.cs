using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private TimeLine timeLine;
    private AudioSource audio;

    public Level level;

    bool cd = false;
    float procTime;

    private void Awake()
    {
        timeLine = GetComponent<TimeLine>();
        audio = GetComponent<AudioSource>();

        level = GameObject.Find("TransferLevel").GetComponent<TransferLevel>().level;
    }

    private void Start()
    {
        audio.clip = level.song;
        audio.Play();
        timeLine.StartTime();
    }
	
    private void Update()
    {
        for(int i = 0; i < level.events.Count; i++)
        {
            if (level.events[i].time - level.events[i].e.inpactTime == timeLine.roundedTime && !cd)
            {
                InstatiateEvent(level.events[i].e.eventSpawns);
                procTime = timeLine.roundedTime;
                cd = true;
            }
        }
        if(cd && procTime + 1 < timeLine.roundedTime)
        {
            cd = false;
        }
    }

    private void InstatiateEvent(List<GameObject> eventObjects)
    {
        for (int i = 0; i < eventObjects.Count; i++)
        {
            Instantiate(eventObjects[i], this.gameObject.transform.position, Quaternion.identity);
        }
    }
}
