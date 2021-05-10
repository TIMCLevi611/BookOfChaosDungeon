using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    private LockedDoor lockedDoor;

    // Start is called before the first frame update
    void Start()
    {
        lockedDoor = GameObject.Find("LockDoor").GetComponent<LockedDoor>(); //Connects the locked door script to this script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * Unlocks the Door when clicked
     */
    private void OnMouseDown()
    {
        lockedDoor.isLocked = false; 
    }
}
