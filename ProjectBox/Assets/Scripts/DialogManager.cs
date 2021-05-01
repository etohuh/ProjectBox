using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogText;

    public GameObject nextButton;

    private Queue<string> sentences;

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

        nameText.text = dialog.name;

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
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence) {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray()) {
            dialogText.text += letter;
            yield return null;
        }
    }

    public void EndDialog() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
