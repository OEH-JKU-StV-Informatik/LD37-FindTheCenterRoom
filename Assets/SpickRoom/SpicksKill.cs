using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpicksKill : MonoBehaviour
{
    private bool teleportedUP = true;
    private bool teleportedDown = true;
    public float time = 0;
    public float prositonDown00 = 0;
    public float prositonUp0 = 0;
    public float prositonDown0 = 0;
    public float prositonUp1 = 0;
    public float prositonDown1 = 0;
    public float prositonUp2 = 0;
    public float prositonDown2 = 0;
    public float prositonUp3 = 0;
    public float prositonDown3 = 0;
    public Transform positionUP;
    public Transform positionDown;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time < prositonDown00)
        {
            down();
        }
        else if (time < prositonUp0)
        {
            up();
        }
        else if (time < prositonDown0)
        {
            down();
        }

        else if (time < prositonUp1)
        {
            up();
        }
        else if (time < prositonDown1)
        {
            down();
        }
        else if (time < prositonUp2)
        {
            up();
        }
        else if (time < prositonDown2)
        {
            down();
        }
        else if (time < prositonUp3)
        {
            up();
        }
        else if (time < prositonDown3)
        {
            down();
        }

        else if (time > 120)
        {
            up();
        }
        else
        {
            down();
        }
    }

    public void up()
    {
        if (teleportedUP)
        {
            transform.position = positionUP.transform.position;
            teleportedUP = false;
            teleportedDown = true;
        }
    }

    public void down()
    {
        if (teleportedDown)
        {
            transform.position = positionDown.transform.position;
            teleportedUP = true;
            teleportedDown = false;
        }
    }
}





