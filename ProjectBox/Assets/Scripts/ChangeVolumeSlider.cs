using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeSlider : MonoBehaviour
{
    [SerializeField] private GameObject musicController;
    [SerializeField] private GameObject slider;


    private void Start()
    {
        slider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("VolumePref");
        musicController.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumePref");
    }

    public void ChangeVolume()
    {
        PlayerPrefs.SetFloat("VolumePref", slider.GetComponent<Slider>().value);
        musicController.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumePref");
    }
}
