using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Level", order = 1)]
public class Level : ScriptableObject
{
    public new string name;
    public AudioClip song;
    
    public List<LevelEvent> events = new List<LevelEvent>();
}

[System.Serializable]
public struct LevelEvent
{
    public float time;
    public Event e;
}

