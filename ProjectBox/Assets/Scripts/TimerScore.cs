using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimerScore : MonoBehaviour
{
    [SerializeField] private float timeForOneStar, timeForTwoStar, timeForThreeStar;
    [SerializeField] private int coinOneStar, coinTwoStar, coinThreeStar;


    [SerializeField] private GameObject normalTimer;
    [SerializeField] private GameObject player;

    private UI_Timer uiTimer;
    private int stars, coins;
    //public PlayerPrefs pPrefs;
    private float whatLevel;
    private float record;

    private bool given = false, given2 = false, given3 = false;


    private PlayerState pState;

    private void Start()
    {
        setRecord();
        pState = player.GetComponent<PlayerState>();
        coins = pState.coinAmount;
        whatLevel = SceneManager.GetActiveScene().buildIndex;
        uiTimer = normalTimer.GetComponent<UI_Timer>();
        compare();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {



        print("Hejhej");
        print("record is: " + record);

        if (uiTimer.timer <= timeForThreeStar/* && uiTimer.timer < timeForTwoStar && uiTimer.timer < timeForOneStar*/)
        {
            stars = 3;
        }
        else if (uiTimer.timer <= timeForTwoStar && uiTimer.timer > timeForThreeStar/* && uiTimer.timer < timeForOneStar*/)
        {
            stars = 2;
        }
        else if (uiTimer.timer >= timeForOneStar && uiTimer.timer > timeForTwoStar && uiTimer.timer > timeForThreeStar)
        {
            stars = 1;
        }

        coinsBasedStars();
    }

    private void compare()
    {

        if (record <= timeForThreeStar && record > 0)
        {
            given3 = true;
            given2 = true;
            given = true;
        }
        if (record <= timeForTwoStar && given3 == false && timeForThreeStar < record)
        {
            given2 = true;
            given = true;
        }
        if (record > timeForTwoStar && record < timeForOneStar && given2 == false && given == true && record > timeForTwoStar)
        {
            given = true;
        }

    }

    private void setRecord()
    {
        whatLevel = SceneManager.GetActiveScene().buildIndex;

        if (whatLevel == 1)
        {
            record = PlayerPrefs.GetFloat("level1TimeSpan");
        }
        else if (whatLevel == 2)
        {
            record = PlayerPrefs.GetFloat("level2TimeString");
        }
        else if (whatLevel == 3)
        {
            record = PlayerPrefs.GetFloat("level3TimeString");
        }
        else if (whatLevel == 4)
        {
            record = PlayerPrefs.GetFloat("level4TimeString");
        }
        else if (whatLevel == 5)
        {
            record = PlayerPrefs.GetFloat("level5TimeString");
        }
        else if (whatLevel == 6)
        {
            record = PlayerPrefs.GetFloat("level6TimeString");
        }
        else if (whatLevel == 7)
        {
            record = PlayerPrefs.GetFloat("level7TimeString");
        }
        else if (whatLevel == 8)
        {
            record = PlayerPrefs.GetFloat("level8TimeString");
        }
        else if (whatLevel == 9)
        {
            record = PlayerPrefs.GetFloat("level9TimeString");
        }
        else if (whatLevel == 10)
        {
            record = PlayerPrefs.GetFloat("level10TimeString");
        }



    }

    private void coinsBasedStars()
    {

        if (stars >= 1 && given == false)
        {
            pState.coinAmount += coinOneStar;
            given = true;
        }
        if (stars >= 2 && given2 == false)
        {
            pState.coinAmount += coinTwoStar;
            given2 = true;
        }
        if (stars >= 3 && given3 == false)
        {
            pState.coinAmount += coinThreeStar;
            given3 = true;
        }

    }

}