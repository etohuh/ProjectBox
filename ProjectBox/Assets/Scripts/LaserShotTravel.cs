using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShotTravel : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float timer = 0f;
    private float destroyAfterCollision = 2f;
    public bool hasCollided = false;
    private LaserShot ls;

    void Start()
    {
        rb.velocity = transform.right * -speed;
    }

    private void Update()
    {
        if (hasCollided)
        {
            timer += Time.deltaTime;
            if (timer > destroyAfterCollision)
            {
                hasCollided = false;
                Destroy(gameObject);
                timer = 0f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        hasCollided = true;

        //if (collision.CompareTag("Player"))
        //{
        //    ls.player.GetComponent<PlayerState>().KillPlayer();
        //}


    }
}
