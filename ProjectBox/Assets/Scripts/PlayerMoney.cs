using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public int playerMoney;

    [SerializeField] Text[] moneyUIText;

    private void Start()
    {
        UpdateMoneyUIText();
        playerMoney = PlayerPrefs.GetInt("CoinAmount");
    }

    public bool TryRemoveMoney(int moneyToRemove)
    {
        if (playerMoney >= moneyToRemove)
        {
            playerMoney -= moneyToRemove;
            PlayerPrefs.SetInt("CoinAmount", playerMoney);
            return true;
            
        }
        else
        {
            return false;
        }
    }

    public void UpdateMoneyUIText()
    {
        for (int i = 0; i < moneyUIText.Length; i++)
        {
            moneyUIText[i].text = PlayerPrefs.GetInt("CoinAmount").ToString();
        }
    }
}
