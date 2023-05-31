using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider Slider;
    public float oldVolume;

    void Start()
    {
        oldVolume = Slider.value;
        if (!PlayerPrefs.HasKey("volume")) Slider.value = 1f;
        else Slider.value = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {
        if(oldVolume != Slider.value)
        {
            PlayerPrefs.SetFloat("volume", Slider.value);
            PlayerPrefs.Save();
            oldVolume = Slider.value;

        }
    }
}
