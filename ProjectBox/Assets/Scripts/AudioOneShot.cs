using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioOneShot : MonoBehaviour
{

    public AudioClip impact;
    AudioSource audioSource;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.Play();
    }
}