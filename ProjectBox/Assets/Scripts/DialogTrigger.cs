using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    private void Start() {
        TriggerDialog();
    }

    public void TriggerDialog() {
        //Time.timeScale = 0;
        print("working");
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
