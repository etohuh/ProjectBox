using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    private int gravityconst = 4;

    public Vector3 gravityVector;
    public Rigidbody2D rb;
    public Transform transform;
    private Vector3 directionVector;

    void Start()
    {
        gravityVector = new Vector3(0, -gravityconst, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(gravityVector * rb.mass);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        foreach(ContactPoint2D hitPos in collision.contacts) {
            Debug.Log(hitPos.normal);
            if (hitPos.normal.y == -1)
                gravityVector = new Vector3(0, gravityconst, 0);
            else if (hitPos.normal.x == 1) {
                gravityVector = new Vector3(-gravityconst, 0, 0);
            }
            else if (hitPos.normal.x == -1)
                gravityVector = new Vector3(gravityconst, 0, 0);
            else if(hitPos.normal.y == 1)
                gravityVector = new Vector3(0, -gravityconst, 0);
        }
        
    }

}
