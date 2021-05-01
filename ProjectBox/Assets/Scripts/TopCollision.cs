using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCollision : MonoBehaviour
{

    public GravityController gC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        gC.ResetBools();
        gC.topGravity = true;
    }
}
