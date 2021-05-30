using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompletionSetRecord : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI yourTimeText;
    [SerializeField] private TextMeshProUGUI currentRecordText;
    [SerializeField] private GameObject textRecordObject;
    
    [SerializeField] private Sprite goldSprite;
    [SerializeField] private Sprite silverSprite;
    [SerializeField] private Sprite bronzeSprite;

    public Image medalImage;

    public UI_Timer counterTimer;

    private int whatLevel;

    public bool newRecord = false;
    // Start is called before the first frame update

    private void Start() {
        currentRecordText = currentRecordText.GetComponent<TextMeshProUGUI>();
        yourTimeText = yourTimeText.GetComponent<TextMeshProUGUI>();
        whatLevel = SceneManager.GetActiveScene().buildIndex;
        counterTimer = counterTimer.GetComponent<UI_Timer>();
    }

    public void SetNewRecord() {

        whatLevel = SceneManager.GetActiveScene().buildIndex;

        switch (whatLevel)
        {
            case 1:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level1TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 2:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level2TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 3:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level3TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 4:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level4TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 5:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level5TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 6:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level6TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;


        }

        textRecordObject.SetActive(newRecord);
        newRecord = false;
    }

    public void DisplayMedal(string medal)
    {
        if (medal.Equals("gold"))
        {
            medalImage.sprite = goldSprite;
        }else if (medal.Equals("silver"))
        {
            medalImage.sprite = silverSprite;
        }else if (medal.Equals("bronze"))
        {
            medalImage.sprite = bronzeSprite;
        }else if (medal.Equals("none"))
        {
            medalImage.enabled = false;
        }
    }
}
