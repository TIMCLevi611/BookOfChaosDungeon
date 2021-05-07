using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevers : MonoBehaviour
{
    private Levers levers;

    // Start is called before the first frame update
    void Start()
    {
        levers = GetComponent<Levers>();
    }

    /**
     * Rotates the Red lever
     */
    public void RotateRed()
    {
        if (gameObject.CompareTag("Red"))
        {
            if (levers.isRed) //If lever is facing up
            {
                transform.Rotate(90, 0, 0);
            }
            
            else //If the lever is facing down
            {
                transform.Rotate(-90, 0, 0);
            }
        }
    }

    /**
     * Rotates the Green lever
     */
    public void RotateGreen()
    {
        if (gameObject.CompareTag("Green"))
        {
            if (levers.isGreen) //If lever is facing up
            {
                transform.Rotate(90, 0, 0);
            }

            else //If the lever is facing down
            {
                transform.Rotate(-90, 0, 0);
            }
        }
    }

    /**
     * Rotates the Blue lever
     */
    public void RotateBlue()
    {
        if (gameObject.CompareTag("Blue"))
        {
            if (levers.isBlue) //If lever is facing up
            {
                transform.Rotate(90, 0, 0);
            }

            else //If the lever is facing down
            {
                transform.Rotate(-90, 0, 0);
            }
        }
    }
}
