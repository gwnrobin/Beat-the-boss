﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "Event", order = 2)]
public class Event : ScriptableObject
{
    public new string name;
    public List<GameObject> eventSpawns;

    public float inpactTime;
}
