using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionRestartLevel : MonoBehaviour
{
    [SerializeField] private GameObject deathUI;

    public void CompletionRestart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        deathUI.SetActive(false);
    }
}
