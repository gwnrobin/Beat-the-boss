using UnityEngine;

[System.Serializable]
public struct TimeEvent
{
    public IEvent obstakel;
    public float time;
}

public interface IEvent
{
    void Execute();
}

[CreateAssetMenu(fileName = "event", menuName = "event", order = 1)]
public class CEvent : ScriptableObject
{
    public IEvent cEvent;
}