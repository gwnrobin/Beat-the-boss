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