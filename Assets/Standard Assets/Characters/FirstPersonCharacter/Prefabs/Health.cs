using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    
    public bool damage = false;
    public Slider HealthBar;
    public GameObject Playerspawner;
    public float time;
    public bool countTime = false;
    public int killconter;

    // Use this for initialization
    void Start () {   
    }

    // Update is called once per frame
    void Update()
    {
        Playerspawner = GameObject.Find("PlayerSpawner");
        if (countTime)
        {
            time += Time.deltaTime;
            if (time > 0.5)
            {            
                Playerspawner = GameObject.Find("PlayerSpawner");
                transform.position = Playerspawner.transform.position;
                countTime = false;
                time = 0;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "deadly")
        {
            killconter += 1;
            Playerspawner = GameObject.Find("PlayerSpawner");
            transform.position = Playerspawner.transform.position;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        countTime = true;
    }

    void OnGUI()
    {
    
            GUI.Label(new Rect(0.0f, 0.0f, 128.0f, 32.0f), killconter.ToString());
    }
}
