using System;
using UnityEngine;
using UnityEngine.UI;

public class MusicDropDown : DropDown<AudioClip>
{
    override protected void Awake()
    {
        base.Awake();
        resourcesArray = Resources.LoadAll<AudioClip>("Music");
    }
}
