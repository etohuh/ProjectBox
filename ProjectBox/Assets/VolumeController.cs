using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private AudioSource musicController;

    private void Update()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("VolumePref");
        musicController.volume = PlayerPrefs.GetFloat("MusicVolumePref");
    }
}
