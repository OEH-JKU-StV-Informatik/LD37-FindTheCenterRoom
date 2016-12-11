using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

    public float time;
    public string minutes;
    public string seconds;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        minutes = Mathf.Floor(time / 60).ToString("00");
        seconds = (time % 60).ToString("00");

    }
}
