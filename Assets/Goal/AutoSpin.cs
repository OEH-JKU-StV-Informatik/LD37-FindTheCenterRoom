using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpin : MonoBehaviour {

    public float speed;
    public Vector3 axis;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, axis); 
    }
}
