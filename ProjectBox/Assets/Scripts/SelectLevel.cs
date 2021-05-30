using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{

    public LevelLoader lLoader;
    public int levelNumber;
    [SerializeField] private Rigidbody2D playerRB;

    private void Start()
    {
        playerRB = GameObject.Find("Player").GetComponent<Rigidbody2D>();


    }

    public void StartLevel()
    {
        playerRB.bodyType = RigidbodyType2D.Static;
        lLoader.LoadLevelWithTransition(levelNumber);
        Time.timeScale = 1;
    }
}
