using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallofdeath1 : MonoBehaviour {
    public float time = 5;
    public float speed = -3;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(transform.forward * speed * Time.deltaTime);

        Destroy(gameObject, time);

        
	}
}
