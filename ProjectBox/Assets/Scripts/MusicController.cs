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

    [SerializeField] private AudioClip laser1;
    [SerializeField] private AudioClip laser2;
    [SerializeField] private AudioClip laser3;
    [SerializeField] private AudioClip laser4;
    [SerializeField] private AudioClip laser5;
    [SerializeField] private AudioClip laser6;
    [SerializeField] private AudioClip laserBuzzing;

    [SerializeField] private AudioSource audioSource;

    private bool firstTrack = false;
    private bool secondTrack = false;
    private bool deathTrack = false;

    private bool collisionTrack = false;
    private bool menuSoundTrack = false;
    private bool gravity1Track = false;
    private bool gravity2Track = false;
    private bool gravity3Track = false;
    private bool jumpSoundTrack = false;

    private bool laser1Track = false;
    private bool laser2Track = false;
    private bool laser3Track = false;
    private bool laser4Track = false;
    private bool laser5Track = false;
    private bool laser6Track = false;
    private bool laserBuzzingTrack = false;


    private void Start()
    {
        audioSource.volume = PlayerPrefs.GetFloat("VolumePref");
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

        else if (laser1Track == true)
        {
            audioSource.clip = laser1;
            audioSource.loop = false;
            audioSource.Play();
            laser1Track = false;
        }
        else if (laser2Track == true)
        {
            audioSource.clip = laser2;
            audioSource.loop = false;
            audioSource.Play();
            laser2Track = false;
        }
        else if (laser3Track == true)
        {
            audioSource.clip = laser3;
            audioSource.loop = false;
            audioSource.Play();
            laser3Track = false;
        }
        else if (laser4Track == true)
        {
            audioSource.clip = laser4;
            audioSource.loop = false;
            audioSource.Play();
            laser4Track = false;
        }
        else if (laser5Track == true)
        {
            audioSource.clip = laser5;
            audioSource.loop = false;
            audioSource.Play();
            laser5Track = false;
        }
        else if (laserBuzzingTrack == true)
        {
            audioSource.clip = laserBuzzing;
            audioSource.loop = false;
            audioSource.Play();
            laserBuzzingTrack = false;
        }
        else if (laser6Track == true)
        {
            audioSource.clip = laser6;
            audioSource.loop = false;
            audioSource.Play();
            laser6Track = false;
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

    public void ChangeClipWithButton10()
    {
        laser1Track = true;
    }
    public void ChangeClipWithButton11()
    {
        laser2Track = true;
    }
    public void ChangeClipWithButton12()
    {
        laser3Track = true;
    }
    public void ChangeClipWithButton13()
    {
        laser4Track = true;
    }
    public void ChangeClipWithButton14()
    {
        laser5Track = true;
    }
    public void ChangeClipWithButton15()
    {
        laserBuzzingTrack = true;
    }
    public void ChangeClipWithButton16()
    {
        laser6Track = true;
    }
}
