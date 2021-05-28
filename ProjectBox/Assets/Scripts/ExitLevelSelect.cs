using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevelSelect : MonoBehaviour
{
    public GameObject levelSelect;

    // Start is called before the first frame update


    public void CloseLevelSelect() {
        levelSelect.SetActive(false);

    }
}
