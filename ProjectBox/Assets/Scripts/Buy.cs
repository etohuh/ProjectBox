using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    #region Singleton:Buy

    public static Buy Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion

    [SerializeField] Text[] moneyUIText;

    public int Money;

    void Start()
    {
        UpdateMoneyUIText();
    }

    public void UseMoney (int amount)
    {
        Money -= amount;
    }

    public bool HasEnoughMoney (int amount)
    {
        return (Money >= amount);
    }

    public void UpdateMoneyUIText()
    {
        for (int i = 0; i < moneyUIText.Length; i++)
        {
            moneyUIText[i].text = Money.ToString();
        }
    }

}
