using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("GoalRoom", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
