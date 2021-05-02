using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateCOPY : MonoBehaviour {

    public bool isAlive;
    public Transform startingPos;

    public int coinAmount;

    private Transform respawnPos;

    private Transform playerPos;
    private Rigidbody2D playerRB;

    public GravityController gravController;


    // Start is called before the first frame update
    void Start() {
        playerPos = gameObject.GetComponent<Transform>();
        playerRB = gameObject.GetComponent<Rigidbody2D>();


        isAlive = true;
        playerPos.position = startingPos.position;
        SetRespawnPos(startingPos);
    }

    public void KillPlayer() {

        if (isAlive)
            Respawn();

    }

    private void Respawn() {

        playerPos.position = respawnPos.position;
        playerRB.velocity = new Vector2(0, 0);
        gravController.ResetGravity();

    }

    public void SetRespawnPos(Transform position) {
        respawnPos = position;
    }

}
