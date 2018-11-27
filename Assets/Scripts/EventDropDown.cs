using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EventDropDown : MonoBehaviour
{
    private Dropdown DropDown;
    [SerializeField]
    public IEvent[] events;

    private void Awake()
    {
        DropDown = this.GetComponent<Dropdown>();
        //events = Resources.LoadAll<IEvent>("Events");

        for (int i = 0; i < events.Length; i++)
        {
            //DropDown.options.Add(new Dropdown.OptionData(events[i].name));
        }
    }

    public void OnValueChanged()
    {
        //controller.SetMusic(resourceClips[musicDropDown.value]);
    }
}
