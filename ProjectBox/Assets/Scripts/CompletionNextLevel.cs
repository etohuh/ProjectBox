using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionNextLevel : MonoBehaviour
{
    [SerializeField] private LevelLoader levelLoader;
    [SerializeField] private Rigidbody2D playerRB;


    private void Start()
    {
        playerRB = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    public void NextLevelSelect() {

        if (SceneManager.sceneCountInBuildSettings <= SceneManager.GetActiveScene().buildIndex + 1) {
            playerRB.bodyType = RigidbodyType2D.Static;
            levelLoader.LoadLevelWithTransition(0);
            Time.timeScale = 1;
        }
        else {
            playerRB.bodyType = RigidbodyType2D.Static;
            levelLoader.LoadLevelWithTransition();
            Time.timeScale = 1;
        }

    }

}
