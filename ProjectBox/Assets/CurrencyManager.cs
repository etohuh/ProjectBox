using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{

    [SerializeField] private Text currencyText;
    

    // Start is called before the first frame update
    void Start()
    {
        currencyText.text = PlayerPrefs.GetInt("CoinAmount").ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}