using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour {

    public int maxhealth = 100;
    public int health = 100;
    public int damageAmount = 34;
    public bool damage = false;
    public Slider HealthBar;
    public GameObject Playerspawner;


    // Use this for initialization
    void Start () {
        health = maxhealth;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "deadly")
        {
            
            health -= damageAmount;
            HealthBar.value = health;
            Playerspawner = GameObject.Find("PlayerSpawner");
            transform.position = Playerspawner.transform.position;
        }
        if (collision.gameObject.name == "TeleportA")
        {

        }
    }

 }
