using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ChangeVolumeSlider : MonoBehaviour
{
    [SerializeField] private GameObject slider;

    private void Start()
    {
        slider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("VolumePref");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("VolumePref", slider.GetComponent<Slider>().value);

    }
}
