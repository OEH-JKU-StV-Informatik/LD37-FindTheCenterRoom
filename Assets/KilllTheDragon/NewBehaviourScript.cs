using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody LittelDragon;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter(Collision MC)
    {
        if (MC.gameObject.name == "MC")
        {
            Destroy(gameObject);
        }
    }
}


