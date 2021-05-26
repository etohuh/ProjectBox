using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public Transform playerEyes;
    
    public float gravityconst = 15f;

    private Vector3 gravityVector;
    private Vector3 directionVector;

    public bool leftGravity;
    public bool rightGravity;
    public bool topGravity;
    public bool bottomGravity;

    

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        gravityVector = new Vector3(0, -gravityconst, 0);

    }


    private void Update() {
        if (leftGravity) {
            gravityVector = new Vector3(-gravityconst, 0, 0);
            playerEyes.rotation = Quaternion.Euler(0, 0, -90);
        }else if (rightGravity) {
            gravityVector = new Vector3(gravityconst, 0, 0);
            playerEyes.rotation = Quaternion.Euler(0, 0, 90);
        }else if (topGravity) {
            gravityVector = new Vector3(0, gravityconst, 0);
            playerEyes.rotation = Quaternion.Euler(0, 0, -180);
        }
        else if (bottomGravity) {
            gravityVector = new Vector3(0, -gravityconst, 0);
            playerEyes.rotation = Quaternion.Euler(0, 0, 0);
        }
    }


    private void FixedUpdate() {
        rb.AddForce(gravityVector * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }


    public void ResetBools() {
        leftGravity = false;
        rightGravity = false;
        topGravity = false;
        bottomGravity = false;
    }

    public void ResetGravity() {
        ResetBools();
        playerEyes.rotation = Quaternion.Euler(0, 0, 0);
        gravityVector = new Vector3(0, -gravityconst, 0);
    }

}
