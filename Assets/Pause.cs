using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour {

    public GameObject Canvas;
    public GameObject mainCharacter;
    public Transform gameCamera;
    public Transform pauseCamera;

    public bool Paused;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(Canvas);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused == true)
            {
                Time.timeScale = 1.0f;
                Canvas.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Paused = false;
                mainCharacter.SetActive(true);
                pauseCamera.gameObject.SetActive(false);
            }
            else
            {
                Time.timeScale = 0.0f;
                Canvas.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Paused = true;
                pauseCamera.position = gameCamera.position;
                pauseCamera.rotation = gameCamera.rotation;
                mainCharacter.SetActive(false);
                pauseCamera.gameObject.SetActive(true);
            }
        }
    }
    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        Destroy(mainCharacter);
        Destroy(Canvas);
        Destroy(gameObject);
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        
    }

    public void Quit()
    {
        Application.Quit();
    }


}
