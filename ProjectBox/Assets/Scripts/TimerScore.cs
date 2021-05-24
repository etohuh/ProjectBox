using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimerScore : MonoBehaviour
{
    [SerializeField] private float timeForOneStar, timeForTwoStar, timeForThreeStar;
    [SerializeField] private int coinOneStar, coinTwoStar, coinThreeStar;
    public UI_Timer uiTimer;
    private int stars, coins;
    public PlayerPrefs pPrefs;
    private float whatLevel;
    private float record;

    private CompletionSetRecord recordScript;
    private bool given = false , given2 = false, given3 = false;
    
    
    public PlayerState pState;

    private void Start()
    {
        coins = pState.coinAmount;
        whatLevel = SceneManager.GetActiveScene().buildIndex;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            compare();

            if (uiTimer.timerOn = false && uiTimer.timer <= timeForThreeStar && uiTimer.timer < timeForTwoStar && uiTimer.timer < timeForOneStar)
            {
                stars = 3;
            }
            else if (uiTimer.timerOn = false && uiTimer.timer <= timeForTwoStar && uiTimer.timer > timeForThreeStar && uiTimer.timer < timeForOneStar)
            {
                stars = 2;
            }
            else if (uiTimer.timerOn = false && uiTimer.timer <= timeForOneStar && uiTimer.timer > timeForTwoStar && uiTimer.timer > timeForThreeStar)
            {
                stars = 1;
            }

            coinsBasedStars();
        }
    }

    private void compare()
    {
        whatLevel = SceneManager.GetActiveScene().buildIndex;

        if (whatLevel == 1)
        {
            record = float.Parse(PlayerPrefs.GetString("level1TimeString"));
        }
        else if (whatLevel == 2)
        {
            record = float.Parse(PlayerPrefs.GetString("level2TimeString"));
        }
        else if (whatLevel == 3)
        {
            record = float.Parse(PlayerPrefs.GetString("level3TimeString"));
        }
        else if (whatLevel == 4)
        {
            record = float.Parse(PlayerPrefs.GetString("level4TimeString"));
        }
        else if (whatLevel == 5)
        {
            record = float.Parse(PlayerPrefs.GetString("level5TimeString"));
        }
        else if (whatLevel == 6)
        {
            record = float.Parse(PlayerPrefs.GetString("level6TimeString"));
        }
        else if (whatLevel == 7)
        {
            record = float.Parse(PlayerPrefs.GetString("level7TimeString"));
        }
        else if (whatLevel == 8)
        {
            record = float.Parse(PlayerPrefs.GetString("level8TimeString"));
        }
        else if (whatLevel == 9)
        {
            record = float.Parse(PlayerPrefs.GetString("level9TimeString"));
        }
        else if (whatLevel == 10)
        {
            record = float.Parse(PlayerPrefs.GetString("level10TimeString"));
        }



        if (record <= timeForThreeStar && record > 0)
        {
            given3 = true;
            given2 = true;
            given = true;
        }
        if(record <= timeForTwoStar && given3 == false)
        {
            given2 = true;
            given = true;
        }
        if (record > timeForTwoStar  && record < timeForOneStar && given2 == false)
        {
            given = true;
        }
    }

    private void coinsBasedStars()
    {
        if(stars >= 1 && given2 == false)
        {
            pState.coinAmount += coinOneStar;
            given = true;
        }
        if(stars >= 2 && given2 == false)
        {
            pState.coinAmount += coinTwoStar;
            given2 = true;
        }
        if( stars == 3 && given3 == false)
        {
            pState.coinAmount += coinThreeStar;
            given3 = true;
        }
    }

}