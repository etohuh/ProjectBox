using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionSetRecord : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI yourTimeText;
    [SerializeField] private TextMeshProUGUI currentRecordText;
    [SerializeField] private GameObject textRecordObject;

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
            case 7:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level7TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 8:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level8TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 9:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level9TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;
            case 10:
                currentRecordText.text = "current record: " + PlayerPrefs.GetString("level10TimeString");
                yourTimeText.text = "your time: " + counterTimer.textMP.text;
                break;

        }

        textRecordObject.SetActive(newRecord);
        newRecord = false;
    }
}
