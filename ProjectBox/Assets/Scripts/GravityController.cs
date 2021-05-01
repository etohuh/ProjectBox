using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    private float gravityconst = 20f;

    public Vector3 gravityVector;
    public Rigidbody2D rb;
    public Transform transform;
    private Vector3 directionVector;

    public bool leftGravity;
    public bool rightGravity;
    public bool topGravity;
    public bool bottomGravity;

    void Start()
    {
        gravityVector = new Vector3(0, -gravityconst, 0);
    }


    private void Update() {
        if (leftGravity) {
            gravityVector = new Vector3(-gravityconst, 0, 0);
           // transform.rotation = Quaternion.Euler(0, 0, -90);
        }else if (rightGravity) {
            gravityVector = new Vector3(gravityconst, 0, 0);
            //transform.rotation = Quaternion.Euler(0, 0, 90);
        }else if (topGravity) {
            gravityVector = new Vector3(0, gravityconst, 0);
            //transform.rotation = Quaternion.Euler(0, 0, -180);
        }
        else if (bottomGravity) {
            gravityVector = new Vector3(0, -gravityconst, 0);
            //transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }


    private void FixedUpdate() {
        rb.AddForce(gravityVector * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        //Vector2 hitPos = collision.GetContact(0).normal;
        //Debug.Log(hitPos);
        //if (hitPos.y == -1) {
        //    gravityVector = new Vector3(0, gravityconst, 0);
        //    transform.rotation = Quaternion.Euler(0, 0, -180);
        //    print("up");
        //}
        //else if (hitPos.x == 1) {
        //    gravityVector = new Vector3(-gravityconst, 0, 0);
        //    transform.rotation = Quaternion.Euler(0, 0, -90);
        //    print("left");
        //}
        //else if (hitPos.x == -1) {
        //    gravityVector = new Vector3(gravityconst, 0, 0);
        //    transform.rotation = Quaternion.Euler(0, 0, 90);
        //    print("right");
        //}

        //else if (hitPos.y == 1) {
        //    gravityVector = new Vector3(0, -gravityconst, 0);
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //    print("down");
        //}



    }

    public void ResetBools() {
        leftGravity = false;
        rightGravity = false;
        topGravity = false;
        bottomGravity = false;
    }

    public void ResetGravity() {
        gravityVector = new Vector3(0, -gravityconst, 0);
    }

}
