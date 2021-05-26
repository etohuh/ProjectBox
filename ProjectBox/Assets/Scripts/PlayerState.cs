using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    public bool isAlive;
    public Transform startingPos;
    
    private Transform respawnPos;

    public int coinAmount;
    public bool useStartingPos;

    private Transform playerPos;
    private Rigidbody2D playerRB;

    [SerializeField] private GameObject deathUI;

    public GravityController gravController;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private CompletionRestartLevel restart;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = gameObject.GetComponent<Transform>();
        playerRB = gameObject.GetComponent<Rigidbody2D>();


        isAlive = true;
        if (useStartingPos) {
            playerPos.position = startingPos.position;
            
        }
        SetRespawnPos(startingPos);

    }
    

    public void KillPlayer() {

        if(isAlive)
        {
            audioSource.Play();
            if (PlayerPrefs.GetInt("RespawnPref") == -1)
            {
                deathUI.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                restart.CompletionRestart();
            }
            
      
        }           
    }

    public void Respawn() {
        Time.timeScale = 1;
        deathUI.SetActive(false);
        gravController.ResetGravity();
        playerPos.position = respawnPos.position;
        playerRB.velocity = new Vector2(0, 0);
        
    }

    public void SetRespawnPos(Transform position) {
        respawnPos = position;
    }
    


}
