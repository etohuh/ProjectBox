using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{

    public LevelLoader lLoader;
    public int levelNumber;
    
    public void StartLevel()
    {
        lLoader.LoadLevelWithTransition(levelNumber);
        Time.timeScale = 1;
    }
}
