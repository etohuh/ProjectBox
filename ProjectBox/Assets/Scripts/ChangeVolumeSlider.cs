using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeSlider : MonoBehaviour
{
    [SerializeField] private GameObject musicController;
    [SerializeField] private GameObject slider;


    // Update is called once per frame
    void Update()
    {
        musicController.GetComponent<AudioSource>().volume = slider.GetComponent<Slider>().value;
    }
}
