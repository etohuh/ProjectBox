using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{

    public LevelLoader lLoader;
    public int levelNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void StartLevel()
    {
        lLoader.LoadLevelWithTransition(levelNumber);
    }
}
