using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public float gravityconst = 15f;


    public GameObject gObject;

    public Vector3 gravityVector;
    public Rigidbody2D rb;
    private Vector3 directionVector;

    public bool leftGravity;
    public bool rightGravity;
    public bool topGravity;
    public bool bottomGravity;

    public Transform playerSprite;

    void Start()
    {
        gravityVector = new Vector3(0, -gravityconst, 0);

    }


    private void Update() {
        if (leftGravity) {
            gravityVector = new Vector3(-gravityconst, 0, 0);
            playerSprite.rotation = Quaternion.Euler(0, 0, -90);
        }else if (rightGravity) {
            gravityVector = new Vector3(gravityconst, 0, 0);
            playerSprite.rotation = Quaternion.Euler(0, 0, 90);
        }else if (topGravity) {
            gravityVector = new Vector3(0, gravityconst, 0);
            playerSprite.rotation = Quaternion.Euler(0, 0, -180);
        }
        else if (bottomGravity) {
            gravityVector = new Vector3(0, -gravityconst, 0);
            playerSprite.rotation = Quaternion.Euler(0, 0, 0);
        }
    }


    private void FixedUpdate() {
        rb.AddForce(gravityVector * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }


    public void ResetBools() {
        print("resetfuckj");
        leftGravity = false;
        rightGravity = false;
        topGravity = false;
        bottomGravity = false;
    }

    public void ResetGravity() {
        print("working");
        ResetBools();
        playerSprite.rotation = Quaternion.Euler(0, 0, 0);
        gravityVector = new Vector3(0, -gravityconst, 0);
    }

}
