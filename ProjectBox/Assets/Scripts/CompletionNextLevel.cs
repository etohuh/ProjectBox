using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionNextLevel : MonoBehaviour
{
    [SerializeField] private LevelLoader levelLoader;

    public void NextLevelSelect() {

        if (SceneManager.sceneCountInBuildSettings <= SceneManager.GetActiveScene().buildIndex + 1) {
            levelLoader.LoadLevelWithTransition(0);
            Time.timeScale = 1;
        }
        else {
            levelLoader.LoadLevelWithTransition();
            Time.timeScale = 1;
        }

    }

}
