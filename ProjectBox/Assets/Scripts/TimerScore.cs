using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScore : MonoBehaviour
{
    [SerializeField] private float oneStar, twoStar, threeStar;
    [SerializeField] private int coinOneStar, coinTwoStar, coinThreeStar;
    private float timeCount = 0;
    private int stars, coins;
    private void Start()
    {
        timeCount = 0;

    }
    void Update()
    {
        timeCount += Time.deltaTime;

        if (timeCount <= threeStar && timeCount < twoStar && timeCount < oneStar)
        {
            stars = 3;
        } else if (timeCount <= twoStar && timeCount > threeStar && timeCount < oneStar)
        {
            stars = 2;
        }else if(timeCount <= oneStar && timeCount > twoStar && timeCount > threeStar)
        {
            stars = 1;
        }
    }

    private void coinsBasedStars()
    {
        if(stars == 1)
        {
            coins = coinOneStar;
        }else if(stars == 2)
        {
            coins = coinTwoStar;
        }else if( stars == 3)
        {
            coins = coinThreeStar;
        }
    }

}