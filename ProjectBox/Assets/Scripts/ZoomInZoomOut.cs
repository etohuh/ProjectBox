using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInZoomOut : MonoBehaviour
{

    private Camera mainCamera;
    private float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;
    private Vector2 firstTouchPrevPos, secondTouchPrevPos;

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
        }
    }
}
