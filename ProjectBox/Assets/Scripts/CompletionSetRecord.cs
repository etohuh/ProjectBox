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

    private float whatLevel;

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

        if (whatLevel == 1) {
            currentRecordText.text = "current record: " + PlayerPrefs.GetString("level1TimeString");
            yourTimeText.text = "your time: " + counterTimer.textMP.text;
        }
        else if(whatLevel == 2) {
            currentRecordText.text = "current record: " + PlayerPrefs.GetString("level2TimeString");
            yourTimeText.text = "your time: " + counterTimer.textMP.text;
            print("whatlevel is two poggers");
        }
        else if(whatLevel == 3) {
            currentRecordText.text = "current record: " + PlayerPrefs.GetString("level3TimeString");
            yourTimeText.text = "your time: " + counterTimer.textMP.text;
        }


        if (newRecord) {
            textRecordObject.SetActive(true);
            
        }
        else {
            textRecordObject.SetActive(false);
        }
        newRecord = false;
    }
}
