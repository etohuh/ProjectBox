using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleCharacters : MonoBehaviour
{
    public bool startWobble;
    
    public GameObject boxxie;
    public GameObject tri;
    private Vector3 defaultPos1;
    private Vector3 defaultPos2;

    public float shakeAmount;

    // Start is called before the first frame update
    void Start()
    {
        startWobble = false;
        defaultPos1 = boxxie.transform.position;
        defaultPos2 = tri.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startWobble)
        {
            boxxie.transform.position = defaultPos1 + Random.insideUnitSphere * shakeAmount;
            tri.transform.position = defaultPos2 + Random.insideUnitSphere * shakeAmount;
        }
        
    }
}
