using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuContinue : MonoBehaviour
{
    public GameObject pauseMenu;
    [SerializeField] private GameObject pauseButton;

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
        pauseButton.SetActive(true);
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
