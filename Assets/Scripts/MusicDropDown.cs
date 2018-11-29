using System;
using UnityEngine;
using UnityEngine.UI;

public class MusicDropDown : MonoBehaviour
{
    public Action<AudioClip> SetMusic;

    private Dropdown musicDropDown;
    private AudioClip[] resourceClips;

    private void Awake()
    {
        musicDropDown = this.GetComponent<Dropdown>();
        resourceClips = Resources.LoadAll<AudioClip>("Music");

        for (int i = 0; i < resourceClips.Length; i++)
        {
            musicDropDown.options.Add(new Dropdown.OptionData(resourceClips[i].name));
        }
        SetDefault();
    }

    public void OnValueChanged()
    {
        SetMusic(resourceClips[musicDropDown.value]);
    }

    private void SetDefault()
    {
        GetComponentInChildren<Text>().text = resourceClips[0].name;
    }
}
