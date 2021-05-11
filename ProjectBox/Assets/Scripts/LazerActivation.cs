using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LazerActivation : MonoBehaviour
{

    [SerializeField] private GameObject lazer;
    [SerializeField] private float timeToToggle, activatedTimer;
    private float timeCount = 0;


    private void Start()
    {
        timeCount = timeToToggle;

    }

    private void Update()
    {

        if (timeCount > 0)
        {
            timeCount -= Time.deltaTime;
        }
        else
        {
            ToggleLazer();
            
            
        }
    }

    public void ToggleLazer()
    {
        if (lazer.activeSelf)
        {
            lazer.SetActive(false);
            timeCount = timeToToggle;
        }
        else if (!lazer.activeSelf)
        {
            lazer.SetActive(true);
            timeCount = activatedTimer;
        }
        
    }
}
