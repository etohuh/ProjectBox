using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioClip vaporWave1;
    [SerializeField] private AudioClip vaporWave2;
    [SerializeField] private AudioClip deathSound;

    [SerializeField] private AudioClip collision;
    [SerializeField] private AudioClip menuSound;
    [SerializeField] private AudioClip gravity1;
    [SerializeField] private AudioClip gravity2;
    [SerializeField] private AudioClip gravity3;
    [SerializeField] private AudioClip jumpSound;

    [SerializeField] private AudioSource audioSource;

    private bool firstTrack = true;
    private bool secondTrack = false;
    private bool deathTrack = false;

    private bool collisionTrack = false;
    private bool menuSoundTrack = false;
    private bool gravity1Track = false;
    private bool gravity2Track = false;
    private bool gravity3Track = false;
    private bool jumpSoundTrack = false;


    private void Start()
    {
        audioSource.clip = vaporWave1;

    }
    // Update is called once per frame
    void Update()
    {
        if (firstTrack == true)
        {
            audioSource.clip = vaporWave1;        
            audioSource.loop = true;
            audioSource.Play();        
            firstTrack = false; 
        }
        else if (secondTrack == true)
        {
            audioSource.clip = vaporWave2;
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
        else if (collisionTrack == true)
        {
            audioSource.clip = collision;
            audioSource.loop = false;
            audioSource.Play();
            collisionTrack = false;
        }
        else if (menuSoundTrack == true)
        {
            audioSource.clip = menuSound;
            audioSource.loop = false;
            audioSource.Play();
            menuSoundTrack = false;
        }
        else if (gravity1Track == true)
        {
            audioSource.clip = gravity1;
            audioSource.loop = false;
            audioSource.Play();
            gravity1Track = false;
        }
        else if (gravity2Track == true)
        {
            audioSource.clip = gravity2;
            audioSource.loop = false;
            audioSource.Play();
            gravity2Track = false;
        }
        else if (gravity3Track == true)
        {
            audioSource.clip = gravity3;
            audioSource.loop = false;
            audioSource.Play();
            gravity3Track = false;
        }
        else if (jumpSoundTrack == true)
        {
            audioSource.clip = jumpSound;
            audioSource.loop = false;
            audioSource.Play();
            jumpSoundTrack = false;
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
    public void ChangeClipWithButton4()
    {
        collisionTrack = true;
    }
    public void ChangeClipWithButton5()
    {
        menuSoundTrack = true;
    }
    public void ChangeClipWithButton6()
    {
        gravity1Track = true;
    }
    public void ChangeClipWithButton7()
    {
        gravity2Track = true;
    }
    public void ChangeClipWithButton8()
    {
        gravity3Track = true;
    }
    public void ChangeClipWithButton9()
    {
        jumpSoundTrack = true;
    }
}
