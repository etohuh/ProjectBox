using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOrbs : MonoBehaviour
{
    public Transform target;

    public float speed;

    // Update is called once per frame
    void Update()
    {   
        gameObject.transform.RotateAround(target.position, Vector3.forward, Time.deltaTime*speed); ;
    }
}
