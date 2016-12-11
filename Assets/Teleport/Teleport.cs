using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public bool teleportOk = false;
    public GameObject Playerspawner;
    private string randomString;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);
   
    }
	
	// Update is called once per frame
	void Update () {
        Playerspawner = GameObject.Find("PlayerSpawner");
        if (teleportOk)
        {
            transform.position = Playerspawner.transform.position;
            teleportOk = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch((int)Random.Range(1, 4)) {
            case 1:
                randomString = "RedRoome";
                break;
            case 2:
                randomString = "BlueRoom";
                break;
            case 3:
                randomString = "BrownRoom";
                break;
            default:
                break;
        }
     
        if(collision.gameObject.name == "TeleportPoint")
        {
            teleportOk = true;
            SceneManager.LoadScene(randomString, LoadSceneMode.Single);
            

        }
        

           
    }
}
