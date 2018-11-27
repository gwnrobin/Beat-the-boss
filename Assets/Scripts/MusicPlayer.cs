using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    private bool beenPlayed = false;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SetMusic(AudioClip clip)
    {
        audioSource.clip = clip;
        beenPlayed = false;
    }

    public void MusicPlay()
    {
        if(beenPlayed)
        {
            audioSource.UnPause();
        }
        else
        {
            audioSource.Play();
            beenPlayed = true;
        }
    }

    public void MusicPause()
    {
        audioSource.Pause();
    }

    public void SkipInTime(float value)
    { 
        audioSource.time = value;
    }
}
