using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    public float speed;
    public Rigidbody MC;
    public float jumpForce;
    public bool canJump = false;
    // Use this for initialization
    void Start()
    {
        MC = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        float forward = Input.GetAxis("Horizontal");
        float up = Input.GetAxis("Jump");
        MC.AddForce(forward * speed, 0, 0, ForceMode.Force);
        if (canJump)
        {
            MC.AddForce(0, up * jumpForce, 0, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision BeginnEnd)
    {
        
        
            canJump = true;
        
    }
    void OnCollisionExit(Collision BeginnEnd)
    {
        canJump = false;
    }


}
