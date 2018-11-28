using UnityEditor;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    private Level newLevel;

    private AudioClip currentClip;

    private void Awake(){ newLevel = ScriptableObject.CreateInstance<Level>(); }

    public void SetName(string name)
    {
        newLevel.name = name;
    }

    public void SetSong(AudioClip clip)
    {
        newLevel.song = clip;
    }

    public void SetEvent(float t, Event ev)
    {
        newLevel.events.Add(new LevelEvent()
        {
            time = t,
            e = ev
        });
    }

    public void SaveLevel()
    {
        AssetDatabase.CreateAsset(newLevel,"Assets/Resources/Levels/" + newLevel.name + ".asset");
        AssetDatabase.Refresh();
    }

    public void ResetNewLevel()
    {
        newLevel = ScriptableObject.CreateInstance<Level>();
    }
}
