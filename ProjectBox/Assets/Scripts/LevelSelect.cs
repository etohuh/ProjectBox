using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class LevelSelect : MonoBehaviour
{
    public TextMeshProUGUI recordTextLevel1,
        recordTextLevel2,
        recordTextLevel3,
        recordTextLevel4,
        recordTextLevel5,
        recordTextLevel6;
    public GameObject levelSelect;
    private TextMeshProUGUI[] recordArray; 
    private TextMeshProUGUI previous;
    [SerializeField] private GameObject deathUI;
    private void Awake()
    {
        recordArray = new TextMeshProUGUI[6];
        recordArray[0] = recordTextLevel1;
        recordArray[1] = recordTextLevel2;
        recordArray[2] = recordTextLevel3;
        recordArray[3] = recordTextLevel4;
        recordArray[4] = recordTextLevel5;
        recordArray[5] = recordTextLevel6;

    }


    public void OpenLevelSelect() {
        levelSelect.SetActive(true);
        recordTextLevel1.text = PlayerPrefs.GetString("level1TimeString");
        recordTextLevel2.text = PlayerPrefs.GetString("level2TimeString");
        recordTextLevel3.text = PlayerPrefs.GetString("level3TimeString");
        recordTextLevel4.text = PlayerPrefs.GetString("level4TimeString");
        recordTextLevel5.text = PlayerPrefs.GetString("level5TimeString");
        recordTextLevel6.text = PlayerPrefs.GetString("level6TimeString");

        foreach (var record in recordArray)
        {
            
            if (!record.text.Equals("") || !previous.text.Equals(""))
            {
                record.GetComponentInParent<Button>().interactable = true;
            }
            previous = record;
        }
        
    }
}
