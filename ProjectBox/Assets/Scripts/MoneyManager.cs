using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] Text moneyText;
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
