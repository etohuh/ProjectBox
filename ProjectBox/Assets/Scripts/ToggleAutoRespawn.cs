using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAutoRespawn : MonoBehaviour
{
    [SerializeField] private Toggle toggleRespawn;
    public int respawn = -1;


    private void Start()
    {
        bool autoRestart = (PlayerPrefs.GetInt("RespawnPref") == 1) ? true : false;

        toggleRespawn.isOn = autoRestart;
    }

    public void AutoRespawn()
    {       
        if (respawn == 1)
        {
            respawn = -1;
        }
        else if (respawn == -1)
        {
            respawn = 1;
        }     

        PlayerPrefs.SetInt("RespawnPref", respawn);
    }
}
