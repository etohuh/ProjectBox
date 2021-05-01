using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate() {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothPos;
    }
}

