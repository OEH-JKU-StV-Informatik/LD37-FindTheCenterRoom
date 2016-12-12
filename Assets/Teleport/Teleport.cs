using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleport : MonoBehaviour {


    public GameObject Playerspawner;
    private string randomString;
    public bool pinkComplete, redComplete, brownComplete, blueComplete, violetComplete, spikeComplete, greenComplete;
    public GameObject Canvas;
    public GameObject PauseMenu;



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
            if (pinkComplete && blueComplete && greenComplete && spikeComplete && redComplete && brownComplete && violetComplete)
            {
                randomString = "GoalRoom";
            }
            else
            {
                bool otherRoom = false;
                do
                {
                    switch ((int)Random.Range(1, 8))
                    {
                        case 1:
                            if (redComplete == false)
                            {
                                randomString = "RedRoome";
                                redComplete = true;
                                otherRoom = false;
                            }
                            else
                            {
                                otherRoom = true;
                            }
                            break;
                        case 2:
                            if (blueComplete == false)
                            {
                                randomString = "BlueRoom";
                                blueComplete = true;
                                otherRoom = false;
                            }
                            else
                            {
                                otherRoom = true;
                            }
                            break;
                        case 3:
                            if (brownComplete == false)
                            {
                                randomString = "BrownRoom";
                                brownComplete = true;
                                otherRoom = false;
                            }
                            else
                            {
                                otherRoom = true;
                            }
                            break;
                        case 4:
                            if (violetComplete == false)
                            {
                                randomString = "VioletRoom";
                                violetComplete = true;
                                otherRoom = false;
                            }
                            else
                            {
                                otherRoom = true;
                            }
                            break;
                        case 5:
                            if (pinkComplete == false)
                            {
                                randomString = "PinkRoom";
                                pinkComplete = true;
                                otherRoom = false;
                            }
                            else
                            {
                                otherRoom = true;
                            }
                            break;
                        case 6:
                            if (spikeComplete == false)
                            {
                                randomString = "SpickRoom";
                                spikeComplete = true;
                                otherRoom = false;
                            }
                            else
                            {
                                otherRoom = true;
                            }
                            break;
                        case 7:
                            if (greenComplete == false)
                            {
                                randomString = "GreenRoom";
                                greenComplete = true;
                                otherRoom = false;
                            }
                            else
                            {
                                otherRoom = true;
                            }
                            break;
                        default:
                            break;
                    }
                } while (otherRoom);
            }
            SceneManager.LoadScene(randomString, LoadSceneMode.Single);
            

        }
     
    }

    private void OnLevelWasLoaded(int level)
    {
        Playerspawner = GameObject.Find("PlayerSpawner");
        transform.position = Playerspawner.transform.position;
 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "win")
        {
            SceneManager.LoadScene("MainMenuWin", LoadSceneMode.Single);
            Destroy(gameObject);
            Destroy(Canvas);
            Destroy(PauseMenu);
           
}
    }


}
