using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInZoomOut : MonoBehaviour
{
    public GameObject endPoint;
    public Transform player;
    private Camera mainCamera;
    private float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;
    private Vector2 firstTouchPrevPos, secondTouchPrevPos;
    private float timeSinceLastcall;

    public Transform endPointer;
    public LineRenderer lr;

    [SerializeField] float zoomModifierSpeed = 0.1f;
    

    void Start()
    {
        mainCamera = transform.GetComponent<Camera>();
    }

 
    void Update()
    {
        CameraView();

        timeSinceLastcall += Time.deltaTime;
        if(timeSinceLastcall >= 0.7)
        {
            if (mainCamera.orthographicSize > 4 && mainCamera.orthographicSize < 5)
            {
                mainCamera.orthographicSize = 4f;
            }
        }
    }

    private void CameraView()
    {
        if (Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);

            firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
            secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

            touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
            touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

            zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;
            if (touchesPrevPosDifference > touchesCurPosDifference)
            {
                mainCamera.orthographicSize += zoomModifier;
            }
            if (touchesPrevPosDifference < touchesCurPosDifference)
            {
                mainCamera.orthographicSize -= zoomModifier;
            }

            //s�tter storlek p� kameran. 4f min 10f max.
            mainCamera.orthographicSize = Mathf.Clamp(mainCamera.orthographicSize, 4f, 10f);
            //Zoom for computer - assigned to "Z"
        }else if (Input.GetKeyDown(KeyCode.Z))
        {
            if (mainCamera.orthographicSize > 4f)
                ResetCamera();
            else
                mainCamera.orthographicSize = 10f;
        }
        
        if (mainCamera.orthographicSize > 4f)
        {
            ShowEnd();
        }
    }

    public void ShowEnd()
    {
        lr.enabled = true;
        lr.SetPosition(0, player.position);
        lr.SetPosition(1, endPoint.transform.position);

        
        lr.enabled = true;
        lr.SetPosition(0, player.position);
        lr.SetPosition(1, endPoint.transform.position);



    }

    public void ResetCamera()
    {
        mainCamera.orthographicSize = 4f;
        lr.enabled = false;
    }
}
