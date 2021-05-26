using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOrbs : MonoBehaviour
{
    public Transform target;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        gameObject.transform.RotateAround(target.position, Vector3.forward, Time.deltaTime*speed); ;
    }
}
