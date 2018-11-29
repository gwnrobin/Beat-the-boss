using UnityEngine;
using UnityEngine.UI;

public class LevelDropDown : MonoBehaviour
{
    private Dropdown dropDown;
    private Level[] levels;

    private void Awake()
    {
        dropDown = this.GetComponent<Dropdown>();
        levels = Resources.LoadAll<Level>("Levels");
    }

    private void Start()
    {
        for (int i = 0; i < levels.Length; i++)
        {
            dropDown.options.Add(new Dropdown.OptionData(levels[i].name));
        }
        SetDefault();
    }

    public void OnValueChange()
    {
        GameObject.Find("Variable").GetComponent<GameVariables>().SetLevel(levels[dropDown.value]);
    }

    private void SetDefault()
    {
        GetComponentInChildren<Text>().text = levels[0].name;
    }
}
