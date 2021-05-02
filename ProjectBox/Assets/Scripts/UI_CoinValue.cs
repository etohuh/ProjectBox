using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CoinValue : MonoBehaviour
{

    private Text textComponent;
    private PlayerState playerState;


    // Start is called before the first frame update
    void Start()
    {
        playerState = GameObject.Find("Player").GetComponent<PlayerState>();
        textComponent = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = playerState.coinAmount.ToString();
    }
}
