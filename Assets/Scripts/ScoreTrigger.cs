using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour
{
    public bool isWall = true; 
    public Text score;
    public static float scoreValue;
    bool isScored;
    
    

    void Start()
    {
        
        isScored = true;
        
        
    }

    
    void Update()
    {
        score.text = "" + scoreValue;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && isScored == true)
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (isWall)
            {
                scoreValue += 5;
                this.enabled = true;
            }
            else
            {
                if (rb.velocity.y >= 0)
                {
                    return;
                }

                scoreValue += 10;
            }
                   
            
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            isScored = false;
        }
    }

}
