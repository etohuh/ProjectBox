using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public GameObject dialogCanvas;

    private void Start() {
        TriggerDialog();
    }

    public void TriggerDialog() {
        Time.timeScale = 1;
        dialogCanvas.SetActive(true);
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
