using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeversUnlock : MonoBehaviour
{
    private Levers levers;
    private LockedDoor lockedDoor;

    // Start is called before the first frame update
    void Start()
    {
        levers = GameObject.Find("Red").GetComponent<Levers>();
        lockedDoor = GameObject.Find("LockDoor").GetComponent<LockedDoor>();
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
            lockedDoor.isLocked = false; //Unlocks the door
        }

        else
        {
            lockedDoor.isLocked = true; //Locks the door
        }
    }
}
