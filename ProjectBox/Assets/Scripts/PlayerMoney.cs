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
    }

    public bool TryRemoveMoney(int moneyToRemove)
    {
        if (playerMoney >= moneyToRemove)
        {
            playerMoney -= moneyToRemove;
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
            moneyUIText[i].text = playerMoney.ToString();
        }
    }
}
