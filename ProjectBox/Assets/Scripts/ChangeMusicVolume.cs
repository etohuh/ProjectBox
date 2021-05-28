using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour
{
    [SerializeField] private GameObject slider;

    private void Start()
    {
        slider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolumePref");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("MusicVolumePref", slider.GetComponent<Slider>().value);

    }
}
