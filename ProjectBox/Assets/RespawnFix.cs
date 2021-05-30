using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFix : MonoBehaviour
{
        public void Start()
        {
                if(PlayerPrefs.GetInt("RespawnPref") != 1 || PlayerPrefs.GetInt("RespawnPref") != -1)
                        PlayerPrefs.SetInt("RespawnPref", -1);
        }

        
}

