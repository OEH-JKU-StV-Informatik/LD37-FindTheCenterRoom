﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallofdeath2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.forward * 2 * Time.deltaTime);
    }
}
