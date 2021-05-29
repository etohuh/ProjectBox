using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public bool dialogComing;

    [SerializeField] private string dialogName;
    

    public void LoadLevelWithTransition()
    {
        if (dialogComing && !dialogName.Equals(""))
        {
            StartCoroutine(LoadLevelTransition(dialogName));
        }
        else
        {
            StartCoroutine(LoadLevelTransition(SceneManager.GetActiveScene().buildIndex + 1));
        }
        
    }
    public void LoadLevelWithTransition(int sceneNumber)
    {
        
        StartCoroutine(LoadLevelTransition(sceneNumber));
    }

    IEnumerator LoadLevelTransition(int sceneNumber)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);
        
        SceneManager.LoadScene(sceneNumber);
    }
    
    IEnumerator LoadLevelTransition(string sceneName)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);
        
        SceneManager.LoadScene(sceneName);
    }
}
