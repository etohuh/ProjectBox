using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelLine : MonoBehaviour
{

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

        lRenderer.SetPosition(0, origin.position);
        lRenderer.SetPosition(1, endpoint + origin.position);

    }

    public void DisableLine() {
        lRenderer.enabled = false;
    }

}
