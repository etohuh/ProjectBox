using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuRestartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartLevel()
    {
        print(SceneManager.GetActiveScene());
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        //SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().ToString()));
    }
}
