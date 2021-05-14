using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionNextLevel : MonoBehaviour
{
    //[SerializeField] private LevelLoader levelLoader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevelSelect() {

        //levelLoader.LoadLevel();

        if (SceneManager.sceneCountInBuildSettings <= SceneManager.GetActiveScene().buildIndex + 1) {
            SceneManager.LoadScene(0);
        }
        else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
            PlayerPrefs.SetInt("CoinAmount", 0);
        }

    }

}
