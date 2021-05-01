using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{

    public bool isAlive;
    public Transform startingPos;
    
    private Transform respawnPos;

    private Transform playerPos;
    private Rigidbody2D playerRB;

    public GravityController gravController;


    // Start is called before the first frame update
    void Start()
    {
        playerPos = gameObject.GetComponent<Transform>();
        playerRB = gameObject.GetComponent<Rigidbody2D>();


        isAlive = true;
        playerPos.position = startingPos.position;
        SetRespawnPos(startingPos);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void KillPlayer() {

        if(isAlive)
            Respawn();

    }

    private void Respawn() {
        gravController.ResetGravity();
        playerPos.position = respawnPos.position;
        playerRB.velocity = new Vector2(0, 0);
        
    }

    public void SetRespawnPos(Transform position) {
        respawnPos = position;
    }

    //public void SetGravity(Vector3 gravityVector) {
    //gameObject.GetComponent<TestingJump>().gravityVector = gravityVector;
    //}


}