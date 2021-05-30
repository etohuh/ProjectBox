using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = PlayerPrefs.GetInt("CoinAmount").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
