using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaOutsidePlayerController : MonoBehaviour
{
    private OutsideDoor outsideDoor;
    private Door door;

    // Start is called before the first frame update
    void Start()
    {
        outsideDoor = GameObject.Find("OutsideDoor").GetComponent<OutsideDoor>(); //Connects PlayerController to OutsideDoor script
        door = GameObject.Find("Door").GetComponent<Door>(); //Connects PlayerController to door script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * If player collides with stuff
     */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OutsideDoor")) //if the player is touching the outside door
        {
            outsideDoor.isMovingDown = true;
        }

        else if (collision.gameObject.CompareTag("Door")) //if the player is touching the inside door
        {
            door.isMovingDown = true;
        }
    }
}
