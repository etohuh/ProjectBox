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
            rb.AddForce(distanceVector*10, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate() {
        rb.AddForce(new Vector3(-9.8f, 0 ,0) * rb.mass);
    }
}
