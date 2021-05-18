using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevers : MonoBehaviour
{
    private Levers levers;
    private SoundManager sound;

    // Start is called before the first frame update
    void Start()
    {
        levers = GetComponent<Levers>(); //Connects the levers script to this one
        sound = GetComponent<SoundManager>(); //Connects the sound manager to this script
    }

    /**
     * Rotates the Red lever
     */
    public void RotateRed()
    {
        sound.PlayLeverBeingPulled(); //Plays the lever being pulled sound

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
        sound.PlayLeverBeingPulled(); //Plays the lever being pulled sound

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
        sound.PlayLeverBeingPulled(); //Plays the lever being pulled sound

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
