using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Level", order = 1)]
public class Level : ScriptableObject
{
    public AudioClip song;
    public new string name;

    public List<TimeEvent> events;
}

