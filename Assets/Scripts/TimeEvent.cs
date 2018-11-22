[System.Serializable]
public struct TimeEvent
{
    public float time;
    public IEvent obstakel;
}

public interface IEvent
{
    void Execute();
}