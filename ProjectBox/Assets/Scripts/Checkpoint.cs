using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer _sRenderer;
    private Transform _transform;

    public AudioSource checkpointSound;
    
    private bool doMovement;
    private Vector3 target;
    public GameObject text;
    public bool checkPointTaken;
    void Start()
    {
        
        _sRenderer = gameObject.GetComponent<SpriteRenderer>();
        _transform = gameObject.GetComponent<Transform>();
        
        target = new Vector3(_transform.position.x + 0.8f, _transform.position.y, 0f);
        checkPointTaken = false;
        text.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (doMovement)
        {
            transform.position = Vector3.Lerp(_transform.position, target, 0.1f);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!this.checkPointTaken)
            {
                checkpointSound.Play();
                collision.gameObject.GetComponent<PlayerState>().SetRespawnPos(gameObject.transform);
                doMovement = true;
                _sRenderer.color = Color.white;
                text.SetActive(true);
                checkPointTaken = true;
            }

        } 
        
    }
}
