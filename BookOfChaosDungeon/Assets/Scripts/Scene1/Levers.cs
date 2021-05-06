using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    private MoveWaterUp moveWaterUp;
    private LockedDoor lockedDoor;
    private RotateLevers rotateLevers;
    private bool isInteracted; //Has the player hit the wrong lever

    public bool isRedUp { get; set; } //Is the Red lever facing up
    public bool isBlueUp { get; set; } //Is the Blue lever facing up
    public bool isGreenUp { get; set; } //Is the Green lever facing up

    // Start is called before the first frame update
    void Start()
    {
        lockedDoor = GameObject.Find("LockDoor").GetComponent<LockedDoor>(); //Connects the locked door script to this script
        moveWaterUp = GameObject.Find("Pool").GetComponent<MoveWaterUp>(); //Connects the Move water script to this script
        rotateLevers = GetComponent<RotateLevers>();
        isInteracted = false;
    }

    // Update is called once per frame
    void Update()
    {
        ActivateWater();
        UnlockDoor();
    }

    /**
     * If the player hits a wrong lever, then the water starts pooring.
     */
    private void ActivateWater()
    {
        if (isInteracted)
        {
            moveWaterUp.failed = true;
        }
    }

    /**
     * Unlocks the door if they hit the right levers.
     */
    private void UnlockDoor()
    {
        if (isGreenUp && isBlueUp && isRedUp)
        {
            lockedDoor.isLocked = false;
            Debug.Log("Unlock");
        }

        else 
        {
            lockedDoor.isLocked = true;
        }
    }

    /**
     * Detects if a lever was pulled then changes it to show.
     */
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Red"))
        {
            rotateLevers.RotateRed();
            
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
            rotateLevers.RotateBlue();

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
            rotateLevers.RotateGreen();
            
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
