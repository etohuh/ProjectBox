using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevelSelect : MonoBehaviour
{
    public GameObject levelSelect;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void CloseLevelSelect() {
        levelSelect.SetActive(false);
    }
}
