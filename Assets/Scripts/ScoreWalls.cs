using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWalls : MonoBehaviour
{
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
    
        public void OnCollisionEnter(Collision other)
        {
        if (other.gameObject.tag == "Ball" && isScored == true)
        { scoreValue += 10; }


    }
    
    public void OnCollisionExit(Collision other)
    {
        
            if (other.gameObject.tag == "Ball")
            { isScored = false; }
        
    }

    
    

}
