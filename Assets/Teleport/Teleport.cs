using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public bool justTeleported = false;
    public GameObject Playerspawner;
  

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
   
    }
	
	// Update is called once per frame
	void Update () {
        if (justTeleported)
        {
            Playerspawner = GameObject.Find("PlayerSpawner");
            transform.position = Playerspawner.transform.position;
            justTeleported = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "TeleportA")
        {
<<<<<<< HEAD
            SceneManager.LoadScene("YellowRoom", LoadSceneMode.Single);
           
=======
            SceneManager.LoadScene("RedRoome", LoadSceneMode.Single);
            justTeleported = true;
>>>>>>> 4c833ef5280117db7ad0c881e8b4b515960012e4
        }
    }
}
