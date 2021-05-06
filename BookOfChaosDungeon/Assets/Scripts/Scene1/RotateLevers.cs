using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevers : MonoBehaviour
{
    private GameObject redLever;
    private GameObject blueLever;
    private GameObject greenLever;
    private Levers levers;
    private Vector3 rotate;
    private float spin;

    // Start is called before the first frame update
    void Start()
    {
        redLever = GameObject.Find("Red");
        blueLever = GameObject.Find("Blue");
        greenLever = GameObject.Find("Green");
        levers = GetComponent<Levers>();
        rotate = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateRed()
    {
        if (levers.isRedUp)
        {
            RotateDown();
        }

        else
        {
            RotateUp();
        }
    }

    public void RotateGreen()
    {
        if(levers.isGreenUp)
        {
            RotateDown();
        }

        else
        {
            RotateUp();
        }
    }

    public void RotateBlue()
    {
        if(levers.isBlueUp)
        {
            RotateDown();
        }

        else
        {
            RotateUp();
        }
    }

    public void RotateDown()
    {
        spin = 1f;

        for (float i = 0; i < 90; i++)
        {
            if (transform.rotation.x != 120)
            {
                transform.Rotate(rotate * spin);
            }
        }
    }

    public void RotateUp()
    {
        spin = -1f;

        for (float i = 0; i < 90; i++)
        {
            if (transform.rotation.x != 30)
            {
                transform.Rotate(rotate * spin);
            }
        }
    }
}
