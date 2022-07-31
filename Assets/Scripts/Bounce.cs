using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    SphereCollider col;
    public PhysicMaterial physic;
    void Start()
    {
        col = GetComponent<SphereCollider>();
        physic.bounciness = 0.76f;
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
