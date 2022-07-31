using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LineSp : MonoBehaviour
{
    public GameObject ball;
    Vector3 startPos;
    Vector3 endPos;
    Camera camera;
    LineRenderer lr;
    Vector3 camOffset = new Vector3(0,0,10);
    public AnimationCurve lineCurve;

    private void Awake()
    {
        
    }
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        camera = Camera.main;
        lr.enabled = false;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(lr.enabled == false)
            {
                lr.enabled = true;
            }

            
            startPos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
            //Vector3 lineRendererStarter = startPos;
            //lineRendererStarter.z = ball.transform.position.z;
            lr.positionCount = 2;
            lr.SetPosition(0, startPos);
            lr.useWorldSpace = true;
            lr.widthCurve = lineCurve;
            lr.numCapVertices = 7;
        }

        if(Input.GetMouseButton(0))
        {
            endPos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
            //Vector3 lineRendererEnding = endPos;
            //lineRendererEnding.z = ball.transform.position.z;
            lr.SetPosition(1, endPos);
            
        }

        if(Input.GetMouseButtonUp(0))
        {
            if(lr.enabled == true)
            {
                lr.enabled = false;
            }

            this.enabled = false;

        }
    }

    

    
}
