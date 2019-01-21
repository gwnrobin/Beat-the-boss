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

    private LevelFactory creator;

    private AudioClip[] resourceClips;

    private AudioClip activeSong;
    private Event activeEvent;

    private void Awake()
    {
        mDropDown = _MDropDown.GetComponent<MusicDropDown>();
        eDropDown = _EDropDown.GetComponent<EventDropDown>();
        slider = _Slider.GetComponent<MusicSlider>();
        player = _JukeBox.GetComponent<MusicPlayer>();

        creator = GetComponent<LevelFactory>();

        resourceClips = Resources.LoadAll<AudioClip>("Music");
    }

    public void Start()
    {
        SetMusic(resourceClips[0]);

        mDropDown.SetResource += SetMusic;
        eDropDown.SetResource += SetEvent;
        slider.SkipForward += SkipInTime;
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

    public void PlaceEvent()
    {
        creator.SetEvent(slider.GetValue(), activeEvent);
    }

    public void SetMusic(AudioClip clip)
    {
        activeSong = clip;
        player.SetMusic(clip);
        slider.SetSliderMax(clip.length);
        slider.SetSliderValue(0);
        creator.SetSong(clip);
        creator.SetName(clip.name);
        PauseMusic();
    }

    public void SetEvent(Event e)
    {
        activeEvent = e;
    }
}
