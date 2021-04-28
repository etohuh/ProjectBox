using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingJump : MonoBehaviour
{
    public Camera mainCamera;
    Vector3 distanceVector;
    Vector3 dragPoint;
    public Rigidbody2D rb;
    public float launchForce;
    private bool isGrounded = false;
    private bool collidedUp;
    private bool collidedDown;
    private bool collidedLeft;
    private bool collidedRight;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            dragPoint = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            print(dragPoint);
            print("working");
        }

        if (Input.GetMouseButton(0)) {
            //draw lines etc
        }

        if (Input.GetMouseButtonUp(0)) {
            distanceVector = dragPoint - mainCamera.ScreenToWorldPoint(Input.mousePosition);
            launchForce = distanceVector.magnitude;
            if(isGrounded == true)
            {
                rb.AddForce(distanceVector * 10, ForceMode2D.Impulse);
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("GroundUp") || collision.gameObject.CompareTag("GroundDown") || collision.gameObject.CompareTag("GroundLeft") || collision.gameObject.CompareTag("GroundRight"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("GroundDown"))
        {
            collidedDown = true;  
        } 
        else if (collision.gameObject.CompareTag("GroundUp"))
        {
            collidedUp = true;
        }
        else if (collision.gameObject.CompareTag("GroundLeft"))
        {
            collidedLeft = true;
        }
        else if (collision.gameObject.CompareTag("GroundRight"))
        {
            collidedRight = true;
        }
       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("GroundUp") || collision.gameObject.CompareTag("GroundDown") || collision.gameObject.CompareTag("GroundLeft") || collision.gameObject.CompareTag("GroundRight"))
        {
            isGrounded = false;
        }
    }

    private void FixedUpdate() {
        rb.AddForce(new Vector3(0, -9.8f ,0) * rb.mass);
        if (collidedUp)
        {
            rb.AddForce(new Vector3(0, 9.8f, 0) * rb.mass);
        } 
        else if (collidedLeft)
        {
            rb.AddForce(new Vector3(-9.8f, 0, 0) * rb.mass);
        }
        else if (collidedRight)
        {
            rb.AddForce(new Vector3(9.8f, 0, 0) * rb.mass);
        }
        else if (collidedDown)
        {
            rb.AddForce(new Vector3(0, -9.8f, 0) * rb.mass);
        }
    }
}
