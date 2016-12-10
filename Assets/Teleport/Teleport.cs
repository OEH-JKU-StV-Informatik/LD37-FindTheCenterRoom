using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public bool justTeleported = false;
    public GameObject Playerspawner;

    private string randomString;

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
        switch((int)Random.Range(1, 3)) {
            case 1:
                randomString = "RedRoome";
                break;
            case 2:
                randomString = "test";
                break;
            default:
                break;
        }
     
        if(collision.gameObject.name == "TeleportA")
        { 

            SceneManager.LoadScene(randomString, LoadSceneMode.Single);
            justTeleported = true;

        }
    }
}
