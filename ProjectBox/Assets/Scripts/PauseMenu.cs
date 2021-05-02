using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvas;
    public GameObject exitObject;

    void Start()
    {
        canvas.SetActive(false);
    }
  
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) == true && exitObject.GetComponent<Quest_Next_Level>().levelComplete == false)
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                canvas.SetActive(true);

            }
            else
            {
                Time.timeScale = 1;
                canvas.SetActive(false);
            }
        }
    }
}
