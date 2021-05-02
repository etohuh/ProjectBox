using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompletionOpenSelect : MonoBehaviour
{

    public GameObject canvas;
    public TextMeshProUGUI recordTextLevel1, recordTextLevel2, recordTextLevel3;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    public void OpenLevelSelect() {
        canvas.SetActive(true);
        recordTextLevel1.text = "current record: " + PlayerPrefs.GetString("level1TimeString");
        recordTextLevel2.text = "current record: " + PlayerPrefs.GetString("level2TimeString");
        recordTextLevel3.text = "current record: " + PlayerPrefs.GetString("level3TimeString");

    }




}
