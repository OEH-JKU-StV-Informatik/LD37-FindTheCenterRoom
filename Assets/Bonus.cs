using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision MC)
    {
        if (MC.gameObject.name == "MC")
        {
            Destroy(gameObject);
        }
    }
}
