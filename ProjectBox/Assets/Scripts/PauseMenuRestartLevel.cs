using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuRestartLevel : MonoBehaviour
{
    public void RestartLevel()
    {
        print(SceneManager.GetActiveScene());
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        //SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().ToString()));
    }
}
