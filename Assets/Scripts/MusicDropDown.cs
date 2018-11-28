using System;
using UnityEngine;
using UnityEngine.UI;

public class MusicDropDown : MonoBehaviour
{
    [SerializeField]
    private GameObject _LevelCreatorController;
    private LevelCreatorController controller;

    private Dropdown musicDropDown;
    private AudioClip[] resourceClips;

    private void Awake()
    {
        musicDropDown = this.GetComponent<Dropdown>();
        controller = _LevelCreatorController.GetComponent<LevelCreatorController>();
        resourceClips = Resources.LoadAll<AudioClip>("Music");

        for (int i = 0; i < resourceClips.Length; i++)
        {
            musicDropDown.options.Add(new Dropdown.OptionData(resourceClips[i].name));
        }
        SetDefault();
    }

    public void OnValueChanged()
    {
        controller.SetMusic(resourceClips[musicDropDown.value]);
    }

    private void SetDefault()
    {
        GetComponentInChildren<Text>().text = resourceClips[0].name;
    }
}
