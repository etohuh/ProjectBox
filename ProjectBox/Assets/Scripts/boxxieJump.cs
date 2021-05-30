using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxxieJump : MonoBehaviour
{
    private bool isPressed;

    private float releaseDelay;
    public float maxDragDistance = 0f;

    private Rigidbody2D rb;
    private Rigidbody2D slingRb;
    private SpringJoint2D sj;
    private LineRenderer lr;
    private TrailRenderer tr;
    


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sj = GetComponent<SpringJoint2D>();
        lr = GetComponent<LineRenderer>();
        tr = GetComponent<TrailRenderer>();
        slingRb = sj.connectedBody;

        tr.enabled = false;

        releaseDelay = 0.1f / (sj.frequency = 1.5f);
    }


    void Update()
    {
        if (isPressed)
        {
            DragBox();
        }
    }

    private void DragBox()
    {
        SetLineRendererPosition();
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(mousePosition, slingRb.position);
        rb.position = mousePosition;

        if(distance > maxDragDistance)
        {
            Vector2 direction = (mousePosition - slingRb.position).normalized;
            rb.position = slingRb.position + direction * maxDragDistance;
        }
        else
        {
            rb.position = mousePosition;
        }
    }

    private void SetLineRendererPosition()
    {
        Vector3[] positions = new Vector3[2];
        positions[0] = rb.position;
        positions[1] = rb.position;
        lr.SetPositions(positions);
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseDelay);
        sj.enabled = false;
        tr.enabled = true;
    }
}
