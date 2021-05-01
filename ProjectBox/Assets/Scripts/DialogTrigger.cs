using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    private void Start() {
        TriggerDialog();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            TriggerDialog();
        }
    }

    public void TriggerDialog() {
        Time.timeScale = 0;
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
