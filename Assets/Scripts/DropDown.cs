using System;
using UnityEngine;
using UnityEngine.UI;

public class DropDown <T> : MonoBehaviour
{ 
    public Action<T> SetResource;

    private Dropdown dropDown;
    private Text textComponent;
    public T[] resourcesArray;

    virtual protected void Awake()
    {
        dropDown = GetComponent<Dropdown>();
        textComponent = GetComponentInChildren<Text>();
    }

    private void Start()
    {
        for (int i = 0; i < resourcesArray.Length; i++)
        {
            string name = resourcesArray[i].GetType().GetProperty("name").GetValue(resourcesArray[i], null).ToString();
            dropDown.options.Add(new Dropdown.OptionData(name));
        }
        SetDefault();
    }

    public void OnValueChange()
    {
        SetResource(resourcesArray[dropDown.value]);
    }

    private void SetDefault()
    {
        textComponent.text = resourcesArray[0].GetType().GetProperty("name").GetValue(resourcesArray[0], null).ToString();
        OnValueChange();
    }
}
