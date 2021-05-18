using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeversUnlock : MonoBehaviour
{
    private Levers levers;
    private LockedDoor lockedDoor;
    private int delay;

    // Start is called before the first frame update
    void Start()
    {
        levers = GameObject.Find("Red").GetComponent<Levers>(); //Connects the levers script to this one
        lockedDoor = GameObject.Find("LockDoor").GetComponent<LockedDoor>(); //Connects the Locked door script to this one
        delay = 0; //How long the door waits to move
    }

    // Update is called once per frame
    void Update()
    {
        UnlockTheDoor();
    }

    /**
     * Unlocks the door if the right combination is entered
     */
    public void UnlockTheDoor()
    {
        if (!levers.isRed && !levers.isGreen && levers.isBlue) //If Red and Green is down and Blue is up
        {
            if(lockedDoor.isLocked) //If the door is locked
            {
                lockedDoor.sound.PlayUnlockDoor(); //Plays the unlock door sound
                
                if(delay >= 400) //If the delay is 400 or greater unlock the door
                { 
                    lockedDoor.isLocked = false; //Unlocks the door
                    delay = 0;
                }
                
                else
                {
                    delay++;
                }
            }
        }

        else //If the wrong combination is present
        {
            lockedDoor.isLocked = true; //Locks the door
        }
    }
}
