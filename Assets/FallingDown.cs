using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDown : MonoBehaviour {
    public float time = 2;
     
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
         Destroy(gameObject, time);
    }
}
