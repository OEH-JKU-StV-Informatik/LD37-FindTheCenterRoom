using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respann : MonoBehaviour {

    public float bulletSpeed =  20;
    public Rigidbody projectile;
    public Transform wall;

	// Use this for initialization
	void Start () {
		
	}
    // Update is called once per frame
    void Update()
    {
     
    }

    void OnTriggerEnter(Collider collision)
    {
        var proj = Instantiate(projectile, wall.position, wall.rotation);
        proj.AddForce(wall.forward * bulletSpeed, ForceMode.VelocityChange);
    }

}
