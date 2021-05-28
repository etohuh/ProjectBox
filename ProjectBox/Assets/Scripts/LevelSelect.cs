using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class LevelSelect : MonoBehaviour
{
    public TextMeshProUGUI recordTextLevel1, recordTextLevel2, recordTextLevel3, recordTextLevel4, recordTextLevel5, 
        recordTextLevel6, recordTextLevel7, recordTextLevel8, recordTextLevel9, recordTextLevel10;
    public GameObject levelSelect;
    private TextMeshProUGUI[] recordArray; 
    private TextMeshProUGUI previous;
    [SerializeField] private GameObject deathUI;
    private void Awake()
    {
        recordArray = new TextMeshProUGUI[10];
        recordArray[0] = recordTextLevel1;
        recordArray[1] = recordTextLevel2;
        recordArray[2] = recordTextLevel3;
        recordArray[3] = recordTextLevel4;
        recordArray[4] = recordTextLevel5;
        recordArray[5] = recordTextLevel6;
        recordArray[6] = recordTextLevel7;
        recordArray[7] = recordTextLevel8;
        recordArray[8] = recordTextLevel9;
        recordArray[9] = recordTextLevel10;
    }


    public void OpenLevelSelect() {
        levelSelect.SetActive(true);
        recordTextLevel1.text = PlayerPrefs.GetString("level1TimeString");
        recordTextLevel2.text = PlayerPrefs.GetString("level2TimeString");
        recordTextLevel3.text = PlayerPrefs.GetString("level3TimeString");
        recordTextLevel4.text = PlayerPrefs.GetString("level4TimeString");
        recordTextLevel5.text = PlayerPrefs.GetString("level5TimeString");
        recordTextLevel6.text = PlayerPrefs.GetString("level6TimeString");
        recordTextLevel7.text = PlayerPrefs.GetString("level7TimeString");
        recordTextLevel8.text = PlayerPrefs.GetString("level8TimeString");
        recordTextLevel9.text = PlayerPrefs.GetString("level9TimeString");
        recordTextLevel10.text = PlayerPrefs.GetString("level10TimeString");
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
