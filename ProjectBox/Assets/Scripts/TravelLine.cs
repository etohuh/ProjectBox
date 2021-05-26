using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelLine : MonoBehaviour
{
    public float maxMagnitude;
    public LineRenderer lRenderer;

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void EnableLine() {
        lRenderer.enabled = true;
    }


    public void DrawLine(Transform origin, Vector3 endpoint) {
        Vector3 myVector;
        myVector = (endpoint + origin.position);
        lRenderer.SetPosition(0, origin.position);
        lRenderer.SetPosition(1, myVector);

    }

    public void DisableLine() {
        lRenderer.enabled = false;
    }

}
