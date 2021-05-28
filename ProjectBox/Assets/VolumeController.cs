using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class VolumeController : MonoBehaviour
{

    private void Update()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("VolumePref");

    }
}
