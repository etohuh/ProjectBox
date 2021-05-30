using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{

    public LevelLoader lLoader;
    public int levelNumber;
    private Rigidbody2D playerRB;

    private void Start()
    {
        playerRB = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        
    }

    public void StartLevel()
    {
        playerRB.velocity = Vector2.zero;
        lLoader.LoadLevelWithTransition(levelNumber);
        Time.timeScale = 1;
    }
}
