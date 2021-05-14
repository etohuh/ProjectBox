using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Update is called once per frame
    public Animator transition;
    public float transitionTime = 1f;

    private void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            Time.timeScale = 1;
            LoadLevelWithTransition();
        }  
    }

    public void LoadLevelWithTransition()
    {
        StartCoroutine(LoadLevelTransition(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevelTransition(int sceneNumber)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneNumber);
    }
}
