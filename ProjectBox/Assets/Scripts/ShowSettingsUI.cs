using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSettingsUI : MonoBehaviour
{
    [SerializeField] private GameObject settingsUI;
    [SerializeField] private GameObject hideOtherUI;

    public void ShowSettings()
    {
        settingsUI.SetActive(true);
        hideOtherUI.SetActive(false);
    }
    
    public void HideSettings()
    {
        settingsUI.SetActive(false);
        hideOtherUI.SetActive(true);
    }
}
