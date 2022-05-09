using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    public Slider sliderSFX;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        sliderSFX.value = PlayerPrefs.GetFloat("SFXVolume", 1.00f);
    }

    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }

    public void SetSFXLevel(float sliderSFXValue)
    {
        mixer.SetFloat("SFXVolume", Mathf.Log10(sliderSFXValue) * 20);
        PlayerPrefs.SetFloat("SFXVolume", sliderSFXValue);
    }
}