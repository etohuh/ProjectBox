using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingJump : MonoBehaviour
{
    private bool touchable = true;
    private float timeSinceLastCall;
    private float prevSize;
    
    public TravelLine tLine;

    public GameObject pointer;
    public Camera mainCamera;
    Vector3 distanceVector;
    Vector3 dragPoint;
    public Rigidbody2D rb;
    private bool isGrounded = false;
    public float maxJumpforce;
    
    private bool prevGrounded;
    private bool looking;

    private void Start()
    {
        looking = true;
        touchable = true;
    }


    void Update()
    {
        if (Input.touchCount == 2 || mainCamera.orthographicSize >= 5f)
        {
            touchable = false;

        }

        if (mainCamera.orthographicSize != 4f)
        {
            looking = true;
        }

        if (looking)
        {
            if (Input.touchCount == 0)
            {
                touchable = true;
                looking = false;
            }
        }


        if (!looking && Input.touchCount == 1)
        {
            touchable = true;
        }
        
        if (Input.GetButtonDown("Fire1") && mainCamera.orthographicSize > 4f)
        {
            mainCamera.GetComponent<ZoomInZoomOut>().ResetCamera();
        }
        
        //UN-COMMENT FOR PHONE
        if (/*Input.touchCount == 1) && */touchable)
        {
            if (Input.GetButtonDown("Fire1") && mainCamera.orthographicSize == 4f)
            {
                if (isGrounded)
                {
                    dragPoint = mainCamera.ScreenToWorldPoint(Input.mousePosition);
                    pointer.SetActive(true);
                    pointer.transform.position = new Vector3(dragPoint.x, dragPoint.y, 0);

                }
            }


            if (Input.GetButton("Fire1") && mainCamera.orthographicSize == 4f)
            {
                if (isGrounded && dragPoint != Vector3.zero)
                {
                    distanceVector = dragPoint - mainCamera.ScreenToWorldPoint(Input.mousePosition);
                    tLine.DrawLine(transform, distanceVector);
                    tLine.EnableLine();

                }

            }

            if (Input.GetButtonUp("Fire1") && mainCamera.orthographicSize == 4f)
            {
                tLine.DisableLine();
                if (isGrounded && dragPoint != Vector3.zero)
                {
                    LaunchPlayer();
                    pointer.SetActive(false);
                }

                dragPoint = Vector3.zero;

            }
        }
    }


    void LaunchPlayer() {
        rb.AddForce(Vector3.ClampMagnitude(distanceVector, maxJumpforce) * 8, ForceMode2D.Impulse);

    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
            
        }
       
    }
    
    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("ground")) {
            isGrounded = false;

        }
    }

}
