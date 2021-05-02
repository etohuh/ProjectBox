using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest_Next_Level : MonoBehaviour
{
    public GameObject completionScreen;
    public UI_Timer timer;
    public CompletionSetRecord recordScript;
    public PlayerState playerState;
    public float whatLevel;
    public bool levelComplete;

    public int coinRequired;

    private void Start() {
        timer = timer.GetComponent<UI_Timer>();
        recordScript = recordScript.GetComponent<CompletionSetRecord>();
        whatLevel = SceneManager.GetActiveScene().buildIndex;
        completionScreen.SetActive(false);
        levelComplete = false;
        whatLevel = SceneManager.GetActiveScene().buildIndex;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {   
           Game_Observer.SaveCoinsToMemory(collision.GetComponent<PlayerState>().coinAmount);


            if (whatLevel == 1) {
                if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level1TimeSpan") || PlayerPrefs.GetFloat("level1TimeSpan") == 0) {
                    Game_Observer.SaveLevel1TimeString(timer.textMP.text);
                    Game_Observer.SaveLevel1TimeSpan(timer.timePlaying);
                    recordScript.newRecord = true;
                }
            }
            if (whatLevel == 2) {
                if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level2TimeSpan") || PlayerPrefs.GetFloat("level2TimeSpan") == 0) {
                    Game_Observer.SaveLevel2TimeString(timer.textMP.text);
                    Game_Observer.SaveLevel2TimeSpan(timer.timePlaying);
                    recordScript.newRecord = true;
                }
            }
            if (whatLevel == 3) {
                if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level3TimeSpan") || PlayerPrefs.GetFloat("level3TimeSpan") == 0) {
                    Game_Observer.SaveLevel3TimeString(timer.textMP.text);
                    Game_Observer.SaveLevel3TimeSpan(timer.timePlaying);
                    recordScript.newRecord = true;
                }
            }

            recordScript.SetNewRecord();
                Time.timeScale = 0;

                completionScreen.SetActive(true);
        }
    }
}

