using UnityEngine.UI;
using UnityEngine;
using System;

public class MusicSlider : MonoBehaviour
{
    public Action<float> SkipForward;

    private Slider slider;

    private bool running = false;
    private float prevValue;

    private void Awake()
    {
        slider = GetComponent<Slider>();
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

    public float GetValue()
    {
        return slider.value;
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
        if (slider.value > prevValue + 1 || slider.value < prevValue -1)
        {
            SkipForward(slider.value);
        }
    }
}
