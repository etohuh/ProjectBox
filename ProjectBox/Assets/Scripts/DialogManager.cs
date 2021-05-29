using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogText;
    public LevelLoader lLoader;
    public AudioSource audioSource;

    private Queue<string> sentences;

    public bool waitForAnimation;

    [SerializeField] private int nextLevelIndex;

    // Start is called before the first frame update
    void Awake()
    {
        sentences = new Queue<string>();
    }
    
    public void StartDialog(Dialog dialog) {
        nameText.text = dialog.name;
        sentences.Clear();
        
        if(dialog.sentences != null) {
            foreach (string sentence in dialog.sentences) {
                sentences.Enqueue(sentence);
            }
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
            audioSource.Play();
            audioSource.pitch = Random.Range(0.9f, 1.1f);
            dialogText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void EndDialog() {

        if (nextLevelIndex != 0)
        {
            lLoader.LoadLevelWithTransition(nextLevelIndex);
            return;
        }
        
        if (!waitForAnimation)
        {
            lLoader.LoadLevelWithTransition();
        }

        if (GameObject.Find("WOBBLE") != null)
        {
            GameObject.Find("WOBBLE").GetComponent<WobbleCharacters>().startWobble = true;
        }
        waitForAnimation = false;
    }
}
