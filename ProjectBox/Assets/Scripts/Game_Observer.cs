using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Observer : MonoBehaviour
{
    public static void SaveCoinsToMemory(int amount)
    {
        PlayerPrefs.SetInt("CoinAmount", PlayerPrefs.GetInt("CoinAmount") + amount);
    }


    //timespan playerprefs
    public static void SaveLevel1TimeString(string recordTime) {
        PlayerPrefs.SetString("level1TimeString", recordTime);
    }
    public static void SaveLevel2TimeString(string recordTime) {
        PlayerPrefs.SetString("level2TimeString", recordTime);
    }
    public static void SaveLevel3TimeString(string recordTime) {
        PlayerPrefs.SetString("level3TimeString", recordTime);
    }

    //string playerprefs
    public static void SaveLevel1TimeSpan(TimeSpan recordTimeSpan) {
        PlayerPrefs.SetFloat("level1TimeSpan", (float)recordTimeSpan.TotalSeconds);
    }

    public static void SaveLevel2TimeSpan(TimeSpan recordTimeSpan) {
        PlayerPrefs.SetFloat("level2TimeSpan", (float)recordTimeSpan.TotalSeconds);
    }

    public static void SaveLevel3TimeSpan(TimeSpan recordTimeSpan) {
        PlayerPrefs.SetFloat("level3TimeSpan", (float)recordTimeSpan.TotalSeconds);
    }


}
