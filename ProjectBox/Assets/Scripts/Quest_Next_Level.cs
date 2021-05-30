using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest_Next_Level : MonoBehaviour
{
    public GameObject completionScreen;
    public UI_Timer timer;
    public CompletionSetRecord recordScript;
    private float whatLevel;
    [SerializeField] private Rigidbody2D playerRB;

    private void Start() {
        timer = timer.GetComponent<UI_Timer>();
        recordScript = recordScript.GetComponent<CompletionSetRecord>();
        completionScreen.SetActive(false);
        whatLevel = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerRB.velocity = Vector2.zero;
            print(whatLevel);
            switch (whatLevel)
           {
               case 1:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level1TimeSpan") || PlayerPrefs.GetFloat("level1TimeSpan") == 0) {
                       Game_Observer.SaveLevel1TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel1TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 2:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level2TimeSpan") || PlayerPrefs.GetFloat("level2TimeSpan") == 0) {
                       Game_Observer.SaveLevel2TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel2TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 3:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level3TimeSpan") || PlayerPrefs.GetFloat("level3TimeSpan") == 0) {
                       Game_Observer.SaveLevel3TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel3TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 4:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level4TimeSpan") || PlayerPrefs.GetFloat("level4TimeSpan") == 0) {
                       Game_Observer.SaveLevel4TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel4TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 5:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level5TimeSpan") || PlayerPrefs.GetFloat("level5TimeSpan") == 0) {
                       Game_Observer.SaveLevel5TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel5TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 6:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level6TimeSpan") || PlayerPrefs.GetFloat("level6TimeSpan") == 0) {
                       print("here");
                       Game_Observer.SaveLevel6TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel6TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               default:
                   return;
               
           }
           
            
            recordScript.SetNewRecord();
            Time.timeScale = 0;
            completionScreen.SetActive(true);
        }
    }
}

