using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTeleport : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Animator _animator;
    [SerializeField] private ParticleSystem _particleSystem;
    
    // Start is called before the first frame update

    public void TeleportPlayer()
    {
        _animator.SetTrigger("shrink");
        _audioSource.Play();
        _particleSystem.Play();
    }
}
