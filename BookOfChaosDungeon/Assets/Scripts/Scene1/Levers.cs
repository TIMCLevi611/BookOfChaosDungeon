using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    private MoveWaterUp moveWaterUp;
    private LockedDoor lockedDoor;
    private RotateLevers rotateLevers;
    public bool isInteracted; //Has the player hit the wrong lever

    public bool isRed { get; set; } //Is red lever facing up
    public bool isGreen { get; set; } //Is the blue lever facing up
    public bool isBlue { get; set; } //Is the Green lever facing up
    public static bool isRedUp { get; set; } //Is the Red lever facing up
    public static bool isBlueUp { get; set; } //Is the Blue lever facing up
    public static bool isGreenUp { get; set; } //Is the Green lever facing up

    // Start is called before the first frame update
    void Start()
    {
        lockedDoor = GameObject.Find("LockDoor").GetComponent<LockedDoor>(); //Connects the locked door script to this script
        moveWaterUp = GameObject.Find("Pool").GetComponent<MoveWaterUp>(); //Connects the Move water script to this script
        rotateLevers = GetComponent<RotateLevers>(); //Connects the Rotate lever script to this script
        isInteracted = false; 
        isRedUp = true;
        isBlueUp = true;
        isGreenUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        ActivateWater();
        UpdateData();
    }

    /**
     * If the player hits a wrong lever, then the water starts pooring.
     */
    private void ActivateWater()
    {
        if (isInteracted) //If the wrong lever has been clicked
        {
            moveWaterUp.failed = true; //Make the water start moving up
        }
    }

    /**
     * Updates the current data
     */
    private void UpdateData()
    {
        isRed = isRedUp;
        isGreen = isGreenUp;
        isBlue = isBlueUp;
    }

    /**
     * Detects if a lever was pulled then changes it to show.
     */
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Red"))
        {
            rotateLevers.RotateRed(); //Rotates the red lever
            
            /*
             * Changes the facing 
             */
            if (isRedUp)
            {
                isRedUp = false;
            }

            else 
            {
                isRedUp = true;
                isInteracted = true;
            } 
        }

        else if (gameObject.CompareTag("Blue"))
        {
            rotateLevers.RotateBlue(); //Rotates the blue lever

            /*
             * Changes the facing 
             */
            if (isBlueUp)
            {
                isBlueUp = false;
                isInteracted = true;
            }

            else
            {
                isBlueUp = true;
            }
        }

        else if (gameObject.CompareTag("Green"))
        {
            rotateLevers.RotateGreen(); //Rotates the green lever

            /*
             * Detects if a lever was pulled then changes it to show.
             */
            if (isGreenUp)
            {
                isGreenUp = false;
            }

            else
            {
                isGreenUp = true;
                isInteracted = true;
            }
        }
    }
}
