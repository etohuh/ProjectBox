using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvas;
    [SerializeField] private Button pauseButton;

    void Start()
    {
        canvas.SetActive(false);
    }

    public void PauseGame()
    {

        pauseButton.enabled = true;
        
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
