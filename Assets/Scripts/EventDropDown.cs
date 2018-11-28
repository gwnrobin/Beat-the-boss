using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EventDropDown : MonoBehaviour
{
    private Dropdown dropDown;

    public Event[] events;

    private void Awake()
    {
        dropDown = this.GetComponent<Dropdown>();
        events = Resources.LoadAll<Event>("Events");
    }

    private void Start()
    {
        for (int i = 0; i < events.Length; i++)
        {
            dropDown.options.Add(new Dropdown.OptionData(events[i].name));
        }
        SetDefault();
    }

    public Event GetEvent()
    {
        return events[dropDown.value];
    }

    private void SetDefault()
    {
        GetComponentInChildren<Text>().text = events[0].name;
    }
}
