using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreatorController : MonoBehaviour
{
    [SerializeField] private GameObject _MDropDown;
    [SerializeField] private GameObject _EDropDown;
    [SerializeField] private GameObject _Slider;
    [SerializeField] private GameObject _JukeBox;

    private MusicDropDown mDropDown;
    private EventDropDown eDropDown;
    private MusicSlider slider;
    private MusicPlayer player;

    private LevelCreator creator;

    private AudioClip[] resourceClips;

    private AudioClip ActiveSong;

    private void Awake()
    {
        mDropDown = _MDropDown.GetComponent<MusicDropDown>();
        eDropDown = _EDropDown.GetComponent<EventDropDown>();
        slider = _Slider.GetComponent<MusicSlider>();
        player = _JukeBox.GetComponent<MusicPlayer>();

        creator = GetComponent<LevelCreator>();

        resourceClips = Resources.LoadAll<AudioClip>("Music");
    }

    public void Start()
    {
        SetMusic(resourceClips[0]);

        mDropDown.SetMusic += SetMusic;
    }

    public void PlayMusic()
    {
        player.MusicPlay();
        slider.MusicPlay();
    }

    public void PauseMusic()
    {
        player.MusicPause();
        slider.MusicPause();
    }

    public void SkipInTime(float value)
    {
        player.SkipInTime(value);
    }

    public void SetEvent()
    {
        creator.SetEvent(slider.GetValue(), eDropDown.GetEvent());
    }

    public void SetMusic(AudioClip clip)
    {
        ActiveSong = clip;
        player.SetMusic(clip);
        slider.SetSliderMax(clip.length);
        slider.SetSliderValue(0);
        creator.SetSong(clip);
        creator.SetName(clip.name);
        PauseMusic();
    }
}
