using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragSp : MonoBehaviour
{
    
    public float power;
    Rigidbody rb;
    public Vector3 maxPower;
    public Vector3 minPower;
    Vector3 force;
    Vector3 startPoint;
    Vector3 endPoint;
    Camera cam;
    public RingMovement ringmovement;
    public GameObject ball;
    bool canMove ;
    
    void Start()
    {
        
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        canMove = false;
        
    }

    
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            startPoint = cam.WorldToScreenPoint(Input.mousePosition);
            startPoint.z = 15;
            
        }

       if(Input.GetMouseButton(0))
        {
            Vector3 currentPoint = cam.WorldToScreenPoint(Input.mousePosition);
            startPoint.z = 15;
            
             
        }
       

       if(Input.GetMouseButtonUp(0))
        {
            
            rb.isKinematic = false;
            endPoint = cam.WorldToScreenPoint(Input.mousePosition);
            endPoint.z = 15;
            float force = Vector3.Distance(startPoint, endPoint);
            force /= 1000;
            Vector3 direction = (startPoint - endPoint).normalized;
            //force = new Vector3(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x),Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * direction * power, ForceMode.Impulse);
            this.enabled = false;
            
            

        }

       
    }
}
