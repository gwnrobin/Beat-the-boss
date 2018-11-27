using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreatorController : MonoBehaviour
{
    [SerializeField] private GameObject _DropDown;
    [SerializeField] private GameObject _Slider;
    [SerializeField] private GameObject _JukeBox;

    private MusicDropDown dropDown;
    private MusicSlider slider;
    private MusicPlayer player;

    private AudioClip[] resourceClips;

    private AudioClip ActiveSong;

    private void Awake()
    {
        dropDown = _DropDown.GetComponent<MusicDropDown>();
        slider = _Slider.GetComponent<MusicSlider>();
        player = _JukeBox.GetComponent<MusicPlayer>();

        resourceClips = Resources.LoadAll<AudioClip>("Music");
        ActiveSong = resourceClips[0];
    }

    public void PlayMusic()
    {
        player.MusicPlay();
        //slider.MusicPlay();
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

    public void SetMusic(AudioClip clip)
    {
        ActiveSong = clip;
        player.SetMusic(clip);
        slider.SetSliderMax(clip.length);
        slider.SetSliderValue(0);
        PauseMusic();
    }

    private void SetDefaults()
    {
        player.SetMusic(ActiveSong);
    }
}
