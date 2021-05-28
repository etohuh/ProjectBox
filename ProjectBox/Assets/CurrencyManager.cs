using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI currencyText;
    [SerializeField] private TextMeshProUGUI currencyTextShade;
    
    // Start is called before the first frame update
    void Start()
    {
        currencyText.text = PlayerPrefs.GetInt("CoinAmount").ToString();
        currencyTextShade.text = PlayerPrefs.GetInt("CoinAmount").ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
