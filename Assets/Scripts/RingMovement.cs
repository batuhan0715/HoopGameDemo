using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMovement : MonoBehaviour
{
    bool canMovement;
    float hor;
    public float horSpeed = 2.5f;
    void Start()
    {
        canMovement = false;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            canMovement = true;
        }

        if (canMovement == true)
        {
            Movement();
        }
        
    }

    public void Movement()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor * horSpeed * Time.deltaTime, 0, 0));
    }
    
    
}
