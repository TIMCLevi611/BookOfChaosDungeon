using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{
    private CapsuleCollider playerCollider;
    private float speedH = 2.0f; //Horizontal speed
    private float speedV = 2.0f; //Vertical speed

    private float yaw = 429f;
    private float pitch = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerCollider = GameObject.Find("Player").GetComponent<CapsuleCollider>(); //Connects player's collider to playerCollider
        Cursor.lockState = CursorLockMode.Locked; //Makes the cursor locked
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamra();
        FixedPlayerCollider();
        FixedMousePosition();
    }

    /**
     * Rotates camra based on mouse location
     */
    public void RotateCamra() 
    {
        yaw += speedH * Input.GetAxis("Mouse X"); //Makes collective movement of Mouse X
        pitch -= speedV * Input.GetAxis("Mouse Y"); //Makes collective movement of Mouse Y

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f); //Rotates camra
    }

    /**
     * Makes it so the collider doesn't move on any axis but y
     */
    public void FixedPlayerCollider()
    {
        playerCollider.transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f); //Makes it so collider doesn't rotate
    }

    /**
     * Makes it so the curser is in the middle of the screen
     */
    public void FixedMousePosition()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //If Escape key is pressed the cursor reappers
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
