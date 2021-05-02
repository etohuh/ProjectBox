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
    void Update() {

        if (Input.GetButtonDown("Fire1") && mainCamera.orthographicSize == 4f) {
            if (isGrounded) {
                dragPoint = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        if (Input.GetButton("Fire1") && mainCamera.orthographicSize == 4f) {
            if (isGrounded && dragPoint != Vector3.zero) {
                distanceVector = dragPoint - mainCamera.ScreenToWorldPoint(Input.mousePosition);
                tLine.DrawLine(transform, distanceVector);
                tLine.EnableLine();
            }

        }

        if (Input.GetButtonUp("Fire1") && mainCamera.orthographicSize == 4f) {

            tLine.DisableLine();
            if (isGrounded && dragPoint != Vector3.zero) {
                LaunchPlayer();
            }
            dragPoint = Vector3.zero;

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
