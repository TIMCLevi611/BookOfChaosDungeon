﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnlockTheMouse();
    }

    /**
     * Unlocks the mouse
     */
    public void UnlockTheMouse()
    {
        Cursor.lockState = CursorLockMode.None; //Unlocks the mouse in the inbetween scenes.
    }
}
