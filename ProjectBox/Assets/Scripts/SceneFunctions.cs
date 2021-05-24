using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFunctions : MonoBehaviour
{
    public void ChangeSceneByAddingIndex(int indexToAdd)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + indexToAdd);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }
}
