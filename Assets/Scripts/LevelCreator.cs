using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    private AudioClip activeSong;

    public void SetActiveSong(AudioClip clip)
    {
        activeSong = clip;
    }
}
