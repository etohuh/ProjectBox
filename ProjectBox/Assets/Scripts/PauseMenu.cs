using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvas;

    void Start()
    {
        canvas.SetActive(false);
        
    }
  
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            PauseGame();
        }
    }

    public void PauseGame() {
        gameObject.SetActive(false);
        if (Time.timeScale == 1) {
            Time.timeScale = 0;
            canvas.SetActive(true);

        }
        else {
            Time.timeScale = 1;
            canvas.SetActive(false);
        }
    }
}
