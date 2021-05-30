using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimerScore : MonoBehaviour
{
    [SerializeField] private float timeForOneStar, timeForTwoStar, timeForThreeStar;
    [SerializeField] private int coinOneStar, coinTwoStar, coinThreeStar, afterGold;


    [SerializeField] private GameObject normalTimer;
    [SerializeField] private GameObject player;

    [SerializeField] private TextMeshProUGUI currencyText;
    [SerializeField] private TextMeshProUGUI currencyShade;

    public CompletionSetRecord recordScript;

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
        if (collision.gameObject.CompareTag("Player"))
        {   
            compare();

            if (uiTimer.timer <= timeForThreeStar/* && uiTimer.timer < timeForTwoStar && uiTimer.timer < timeForOneStar*/)
            {
                stars = 3;
                recordScript.DisplayMedal("gold");
            }
            else if (uiTimer.timer <= timeForTwoStar && uiTimer.timer > timeForThreeStar/* && uiTimer.timer < timeForOneStar*/)
            {
                stars = 2;
                recordScript.DisplayMedal("silver");
            }
            else if (uiTimer.timer <= timeForOneStar && uiTimer.timer > timeForTwoStar && uiTimer.timer > timeForThreeStar)
            {
                stars = 1;
                recordScript.DisplayMedal("bronze");
            }
            else if(uiTimer.timer > timeForOneStar)
            {
                recordScript.DisplayMedal("none");
            }

            coinsBasedStars();
        }
        
    }

    private void compare()
    {
        print(record);

        

        if (record <= timeForThreeStar && record > 0)
        {
            given3 = true;
            given2 = true;
            given = true;
        }
        if (record <= timeForTwoStar && record > timeForThreeStar)
        {
            given2 = true;
            given = true;
        }
        if (record <= timeForOneStar && record > timeForTwoStar && record > timeForThreeStar)
        {
            given = true;
        }
        

    }

    private void setRecord()
    {
        whatLevel = SceneManager.GetActiveScene().buildIndex;
        print(whatLevel);
        

        if (whatLevel == 1)
        {
            record = PlayerPrefs.GetFloat("level1TimeSpan");
        }
        else if (whatLevel == 2)
        {
            record = PlayerPrefs.GetFloat("level2TimeSpan");
        }
        else if (whatLevel == 3)
        {
            record = PlayerPrefs.GetFloat("level3TimeSpan");
        }
        else if (whatLevel == 4)
        {
            record = PlayerPrefs.GetFloat("level4TimeSpan");
        }
        else if (whatLevel == 5)
        {
            record = PlayerPrefs.GetFloat("level5TimeSpan");
        }
        else if (whatLevel == 6)
        {
            record = PlayerPrefs.GetFloat("level6TimeSpan");
        }
        else if (whatLevel == 7)
        {
            record = PlayerPrefs.GetFloat("level7TimeSpan");
        }
        else if (whatLevel == 8)
        {
            record = PlayerPrefs.GetFloat("level8TimeSpan");
        }
        else if (whatLevel == 9)
        {
            record = PlayerPrefs.GetFloat("level9TimeSpan");
        }
        else if (whatLevel == 10)
        {
            record = PlayerPrefs.GetFloat("level10TimeSpan");
        }
        print("record is: " + record);


    }

    private void coinsBasedStars()
    {
        int sum = 0;
        if (record <= timeForThreeStar && given == true && given2 == true && given3 == true && stars == 3)
        {
            pState.coinAmount += afterGold;
            sum += afterGold;
        }
        if (stars >= 1 && given == false)
        {
            pState.coinAmount += coinOneStar;
            sum += coinOneStar;
            given = true;
        }
        if (stars >= 2 && given2 == false)
        {
            pState.coinAmount += coinTwoStar;
            sum += coinTwoStar;
            given2 = true;
        }
        if (stars >= 3 && given3 == false)
        {
            pState.coinAmount += coinThreeStar;
            sum += coinThreeStar;
            given3 = true;
        }

        if (sum > 0)
        {
            currencyText.text = "+" + sum;
            currencyShade.text = "+" + sum;
        }else if (sum == 0)
        {
            currencyText.text = "";
            currencyShade.text = "";
        }

        SetCoinPref();

    }

    private void SetCoinPref()
    {
        PlayerPrefs.SetInt("CoinAmount", pState.coinAmount);
    }

}