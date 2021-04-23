using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip1;
    [SerializeField] private AudioClip audioClip2;
    [SerializeField] private AudioClip deathSound;
    [SerializeField] private AudioSource audioSource;

    private bool firstTrack = true;
    private bool secondTrack = false;
    private bool deathTrack = false;


    private void Start()
    {
        audioSource.clip = audioClip1;

    }
    // Update is called once per frame
    void Update()
    {
        if (firstTrack == true)
        {
            audioSource.clip = audioClip1;        
            audioSource.loop = true;
            audioSource.Play();        
            firstTrack = false; 
        }
        else if (secondTrack == true)
        {
            audioSource.clip = audioClip2;
            audioSource.loop = true;
            audioSource.Play();
            secondTrack = false;
        }
        else if (deathTrack == true)
        {
            audioSource.clip = deathSound;
            audioSource.loop = false;
            audioSource.Play();
            deathTrack = false;
        }

    }

    public void ChangeClipWithButoon1()
    {
        firstTrack = true;
        
    }
    public void ChangeClipWithButton2()
    {
        secondTrack = true;
    }
    public void ChangeClipWithButton3()
    {
        deathTrack = true;
    }
}
