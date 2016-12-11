using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatebluecubes : MonoBehaviour {
    public GameObject[] blueCubes;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        foreach (var blueCube in blueCubes)
        {
            blueCube.SetActive(true);
        }
    }
}
