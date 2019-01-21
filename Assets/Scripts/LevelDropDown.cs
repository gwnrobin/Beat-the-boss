using System;
using UnityEngine;
using UnityEngine.UI;

public class LevelDropDown : DropDown<Level>
{
    override protected void Awake()
    {
        base.Awake();
        resourcesArray = Resources.LoadAll<Level>("Levels");
    }
}
