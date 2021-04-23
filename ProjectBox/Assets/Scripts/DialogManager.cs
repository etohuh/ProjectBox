using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{

    public GameObject[] speakers;

    private Queue<string> sentences;
    public Camera dialogCamera;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialog(Dialog dialog) {
        Debug.Log("Starting conversation with " + dialog.name);

        sentences.Clear();

        foreach(string sentence in dialog.sentences) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

        
    }
    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }

    public void EndDialog() {
        Debug.Log("End of conversation");
    }
}
