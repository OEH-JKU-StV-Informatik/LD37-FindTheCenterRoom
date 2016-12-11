using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleport : MonoBehaviour {


    public GameObject Playerspawner;
    private string randomString;
    public bool pinkComplete, redComplete, brownComplete, blueComplete, violetComplete, spikeComplete, greenComplete;
    

  

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);
   
    }
	
	// Update is called once per frame
	void Update () {
        Playerspawner = GameObject.Find("PlayerSpawner");
    }

    private void OnCollisionEnter(Collision collision)
    {

        

        if (collision.gameObject.name == "TeleportPoint")
        {
            switch ((int)Random.Range(1, 8))
            {
                case 1:
                    if (pinkComplete == false)
                    {
                        randomString = "RedRoome";
                        pinkComplete = true;
                    }
                    break;
                case 2:
                    if (blueComplete == false)
                    {
                        randomString = "BlueRoom";
                        blueComplete = true;
                    }
                    break;
                case 3:
                    if (brownComplete == false)
                    {
                        randomString = "BrownRoom";
                        brownComplete = true;
                    }
                    break;
                case 4:
                    if (violetComplete == false)
                    {
                        randomString = "VioletRoom";
                        violetComplete = true;
                    }
                    break;
                case 5:
                    if (pinkComplete == false)
                    {
                        randomString = "PinkRoom";
                        pinkComplete = true;
                    }
                    break;
                case 6:
                    if (spikeComplete == false)
                    {
                        randomString = "SpickRoom";
                        spikeComplete = true;
                    }
                    break;
                case 7:
                    if (greenComplete == false)
                    {
                        randomString = "GreenRoom";
                        greenComplete = true;
                    }
                    break;
                default:
                    break;
            }
            SceneManager.LoadScene(randomString, LoadSceneMode.Single);
            

        }
     
    }

    private void OnLevelWasLoaded(int level)
    {
        Playerspawner = GameObject.Find("PlayerSpawner");
        transform.position = Playerspawner.transform.position;
    }


    
}
