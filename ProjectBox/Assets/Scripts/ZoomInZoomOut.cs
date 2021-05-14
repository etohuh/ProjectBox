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

            //sätter storlek på kameran. 4f min 10f max.
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

        bool onScreen = endPoint.GetComponent<SpriteRenderer>().isVisible;
        if (onScreen)
        {
            endPoint.GetComponentInChildren<TextMeshPro>().fontSize = 35f;
        }else if (!onScreen)
        {
            lr.enabled = true;
            lr.SetPosition(0, player.position);
            lr.SetPosition(1, endPoint.transform.position);
            
            // float angle = Mathf.Atan2(distanceVector.y, distanceVector.x) * Mathf.Rad2Deg;
            // if (angle < 0)
            //     angle += 360;
            // endPointer.localEulerAngles = new Vector3(0, 0, angle);
            // float borderSize = 100f;
            // Vector3 endPointScreenPoint = mainCamera.WorldToScreenPoint(endPoint.transform.position);
            //
            // Vector3 cappedScreenPosition = endPointScreenPoint;
            // if (cappedScreenPosition.x <= borderSize)
            //     cappedScreenPosition.x = borderSize;
            // if (cappedScreenPosition.x >= Screen.width - borderSize)
            //     cappedScreenPosition.x = Screen.width - borderSize;
            // if (cappedScreenPosition.y <= borderSize)
            //     cappedScreenPosition.y = borderSize;
            // if (cappedScreenPosition.y >= Screen.height - borderSize)
            //     cappedScreenPosition.y = Screen.height - borderSize;
            //
            // Vector3 pointerWorldPos = mainCamera.ScreenToWorldPoint(cappedScreenPosition);
            // endPointer.position = pointerWorldPos;
            // endPointer.localPosition = new Vector3(endPointer.localPosition.x, endPointer.localPosition.y, 0f);
            
        }

    }

    public void ResetCamera()
    {
        mainCamera.orthographicSize = 4f;
        endPoint.GetComponentInChildren<TextMeshPro>().fontSize = 10f;
        lr.enabled = false;
    }
}
