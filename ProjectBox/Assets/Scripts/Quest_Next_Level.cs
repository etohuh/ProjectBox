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
    private float whatLevel;

    private void Start() {
        timer = timer.GetComponent<UI_Timer>();
        recordScript = recordScript.GetComponent<CompletionSetRecord>();
        whatLevel = GameObject.Find("GameObserver").GetComponent<Game_Observer>().levelNumber;
        completionScreen.SetActive(false);
        whatLevel = SceneManager.GetActiveScene().buildIndex;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {   
           Game_Observer.SaveCoinsToMemory(collision.GetComponent<PlayerState>().coinAmount);

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
                       Game_Observer.SaveLevel6TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel6TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 7:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level7TimeSpan") || PlayerPrefs.GetFloat("level7TimeSpan") == 0) {
                       Game_Observer.SaveLevel7TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel7TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 8:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level8TimeSpan") || PlayerPrefs.GetFloat("level8TimeSpan") == 0) {
                       Game_Observer.SaveLevel8TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel8TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 9:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level9TimeSpan") || PlayerPrefs.GetFloat("level9TimeSpan") == 0) {
                       Game_Observer.SaveLevel9TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel9TimeSpan(timer.timePlaying);
                       recordScript.newRecord = true;
                   }
                   break;
               case 10:
                   if (timer.timeSpanCompare <= PlayerPrefs.GetFloat("level10TimeSpan") || PlayerPrefs.GetFloat("level10TimeSpan") == 0) {
                       Game_Observer.SaveLevel10TimeString(timer.textMP.text);
                       Game_Observer.SaveLevel10TimeSpan(timer.timePlaying);
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

