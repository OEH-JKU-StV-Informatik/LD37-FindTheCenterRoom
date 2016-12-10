using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour {

    public int maxhealth = 100;
    public int health = 100;
    public int damageAmount;
    public bool damage = false;
    public Slider HealthBar;
  

    // Use this for initialization
    void Start () {
        health = maxhealth;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "DeathMachine")
        {
            health -= damageAmount;
            HealthBar.value = health;


        }
    }

 }
