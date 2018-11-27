using UnityEngine.UI;
using UnityEngine;

public class MusicSlider : MonoBehaviour
{
    [SerializeField]
    private GameObject _LevelCreatorController;
    private LevelCreatorController controller;

    private Slider slider;

    private bool running = false;
    private float prevValue;

    private void Start()
    {
        slider = GetComponent<Slider>();
        controller = _LevelCreatorController.GetComponent<LevelCreatorController>();
    }

    private void LateUpdate()
    {
        prevValue = slider.value;
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
        if (slider.value > prevValue + 1)
        {
            controller.SkipInTime(slider.value);
        }
    }
}
