using System;
using UnityEngine;
using UnityEngine.UI;

public class EventDropDown : DropDown<Event>
{
    override protected void Awake()
    {
        base.Awake();
        resourcesArray = Resources.LoadAll<Event>("Events");
    }
}
