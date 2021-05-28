using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuContinue : MonoBehaviour
{
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Continue()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
