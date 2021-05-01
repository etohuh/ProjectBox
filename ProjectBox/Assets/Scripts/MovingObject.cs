using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    private GameObject nextTarget;
    [SerializeField] private float speed = 1f;
    void Start()
    {
        nextTarget = point2;
    }
    void Update()
    {
        MoveToPosition(nextTarget);
    }
    void MoveToPosition(GameObject moveToTarget)
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, moveToTarget.transform.position, speed * Time.deltaTime);
        if (gameObject.transform.position == moveToTarget.transform.position)
        {
            ChangeTarget();
        }
    }
    private void ChangeTarget()
    {
        if (nextTarget == point2)
        {
            nextTarget = point1;
        }
        else
        {
            nextTarget = point2;
        }
    }
}
