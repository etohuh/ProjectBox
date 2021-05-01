using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LazerActivation : MonoBehaviour
{

    [SerializeField] private GameObject lazer;
    [SerializeField] private float timeToToggle;
    private float timeCount = 0;


    private void Start()
    {
        timeCount = timeToToggle;
    }

    private void Update()
    {

        if (timeToToggle > 0)
        {
            timeToToggle -= Time.deltaTime;
        }
        else
        {
            ToggleLazer();
            timeToToggle = timeCount;
            print("trigger");
        }
    }

    public void ToggleLazer()
    {
        if (lazer.activeSelf)
        {
            lazer.SetActive(false);
            print ("hey");
        }else if (!lazer.activeSelf)
        {
            lazer.SetActive(true);
            print("bye");
        }
        
    }
}
