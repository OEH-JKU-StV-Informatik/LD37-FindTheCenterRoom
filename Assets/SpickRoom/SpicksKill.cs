using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpicksKill : MonoBehaviour
{
    public float timeLeft = 10;
    public Rigidbody killer;
    public float speed = 20;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;
        switch ((int) timeLeft)
        {
            case (10):
                {
                  
                }
                break;
            default:
                
                    
                break;
                ;
        }
    }



}

