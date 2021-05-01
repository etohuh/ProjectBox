using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingJump : MonoBehaviour
{
    public TravelLine tLine;

    public Camera mainCamera;
    Vector3 distanceVector;
    Vector3 dragPoint;
    public Rigidbody2D rb;
    public float launchForce;
    private bool isGrounded = false;
    public float maxJumpforce;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) {
            if(isGrounded)
                dragPoint = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0)) {
            if (isGrounded) {
                distanceVector = dragPoint - mainCamera.ScreenToWorldPoint(Input.mousePosition);
                tLine.DrawLine(transform, distanceVector);
                tLine.EnableLine();
            }
            
        }

        if (Input.GetMouseButtonUp(0)) {
            
            tLine.DisableLine();
            if(isGrounded == true)
            {
                LaunchPlayer();
            }
            dragPoint = Vector3.zero;
            
        }

        
    }

    void LaunchPlayer() {
        rb.AddForce(Vector3.ClampMagnitude(distanceVector, maxJumpforce) * 8, ForceMode2D.Impulse);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("GroundUp") || collision.gameObject.CompareTag("GroundDown") || collision.gameObject.CompareTag("GroundLeft") || collision.gameObject.CompareTag("GroundRight"))
        {
            isGrounded = true;
        }
       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("GroundUp") || collision.gameObject.CompareTag("GroundDown") || collision.gameObject.CompareTag("GroundLeft") || collision.gameObject.CompareTag("GroundRight"))
        {
            isGrounded = false;
        }
    }

}
