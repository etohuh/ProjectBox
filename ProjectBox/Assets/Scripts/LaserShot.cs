using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShot : MonoBehaviour
{
    //public GameObject player;
    [SerializeField] private float timer = 0f;
    public float shootAgain = 4f;

    [SerializeField] private GameObject laserShot;
    [SerializeField] private Transform startPoint;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > shootAgain)
        {
            laserShot.GetComponent<SpriteRenderer>().enabled = true;
            Instantiate(laserShot, startPoint.position, laserShot.transform.rotation);
            timer = 0f;
        }       
    }
}
