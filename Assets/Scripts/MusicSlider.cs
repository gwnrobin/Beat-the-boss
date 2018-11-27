using UnityEngine.UI;
using UnityEngine;

public class MusicSlider : MonoBehaviour
{
    [SerializeField]
    private GameObject _LevelCreatorController;
    private LevelCreatorController controller;

    private Slider slider;

    private bool running = false;

    private void Start()
    {
        slider = GetComponent<Slider>();
        controller = _LevelCreatorController.GetComponent<LevelCreatorController>();
    }

    private void Update()
    {
        if(running)
        {
            slider.value += Time.deltaTime;
        }
    }

    public void MusicPlay()
    {
        running = true;
    }

    public void MusicPause()
    {
        running = false;
    }

    public void SetSliderValue(float value)
    {
        slider.value = value;
    }

    public void SetSliderMax(float value)
    {
        slider.maxValue = value;
    }

    public void OnValueChanged()
    {
        controller.SkipInTime(slider.value);
    }
}
