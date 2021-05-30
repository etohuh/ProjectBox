using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Observer : MonoBehaviour
{
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
    public static void SaveLevel4TimeString(string recordTime) {
        PlayerPrefs.SetString("level4TimeString", recordTime);
    }
    public static void SaveLevel5TimeString(string recordTime) {
        PlayerPrefs.SetString("level5TimeString", recordTime);
    }
    public static void SaveLevel6TimeString(string recordTime) {
        PlayerPrefs.SetString("level6TimeString", recordTime);
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
    
    public static void SaveLevel4TimeSpan(TimeSpan recordTimeSpan) {
        PlayerPrefs.SetFloat("level4TimeSpan", (float)recordTimeSpan.TotalSeconds);
    }
    public static void SaveLevel5TimeSpan(TimeSpan recordTimeSpan) {
        PlayerPrefs.SetFloat("level5TimeSpan", (float)recordTimeSpan.TotalSeconds);
    }
    public static void SaveLevel6TimeSpan(TimeSpan recordTimeSpan) {
        PlayerPrefs.SetFloat("level6TimeSpan", (float)recordTimeSpan.TotalSeconds);
    }



}
