using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Timer : MonoBehaviour {

    public TextMeshProUGUI textMP;
    public float timer;

    public TimeSpan timePlaying;
    public float timeSpanCompare;

    //private int minutes, seconds, milliseconds;

    public bool timerOn;

    // Start is called before the first frame update
    void Start() {
        textMP = GetComponent<TextMeshProUGUI>();
        timerOn = true;

    }

    // Update is called once per frame
    void Update() {
        if (timerOn) {
            timer += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timer);

            textMP.text = timePlaying.ToString("mm':'ss':'ff");
        }
        timeSpanCompare = (float)timePlaying.TotalSeconds;
    }

    public bool getTimerOn()
    {
        return timerOn;
    }
    public float getTimer()
    {
        return timer;
    }
     
}
