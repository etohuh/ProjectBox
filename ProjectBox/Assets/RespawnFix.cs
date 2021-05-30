using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFix : MonoBehaviour
{
        public void Start()
        {
                if(!PlayerPrefs.HasKey("RespawnPref"))
                        PlayerPrefs.SetInt("RespawnPref", -1);
                        
        }

        
}

